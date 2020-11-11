using aimoyu.DbHelp;
using aimoyu.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI

{
    public partial class SoContent : Form
    {
        /// <summary>
        /// 全部章节
        /// </summary>
        public List<string> chapterList = null;

        private readonly XmlServices xmlService = new XmlServices();

        /// <summary>
        /// 目录URL
        /// </summary>
        public string catalogUrl = "";

        /// <summary>
        /// 内容URL
        /// </summary>
        public string contentUrl = "";

        /// <summary>
        /// 搜索书名
        /// </summary>
        public string bookName = "";

        //实例化一个委托
        public showForm sFrom;
        //实例化一个委托
        public parentShow pShow;

        public SoContent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        // 上一章
        private void Previous_Click(object sender, EventArgs e)
        {
            int sy= chapterList.FindIndex(n=>n== contentUrl);
            if (sy == 0)
            {
                MessageBox.Show("已到达首章", "提示", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                contentUrl = chapterList[sy-1].ToString();
                LoadQuery();
            }
        }

        // 下一章
        private void Next_Click(object sender, EventArgs e)
        {
            int sy = chapterList.FindIndex(n => n == contentUrl);
            if (sy == chapterList.Count())
            {
                MessageBox.Show("已到达末章", "提示", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                contentUrl = chapterList[sy + 1].ToString();
                LoadQuery();
            }
        }
        PublicServices ps = new PublicServices();
        // 加载数据设置样式
        public void LoadQuery(bool bol =true)
        {
            try
            {
                if (bol)
                    ps.MessageBoxShow(this.PointToScreen(new Point(0, 0)));
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += BgWorker_DoWork;
                bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
                bgWorker.RunWorkerAsync();
                SetStyle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        // <summary>
        /// 数据查询之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbl_Title.Text = titleName;
            this.txt_Content.Text = "";
            this.txt_Content.Text = content;
            XmlServices.EditViceDirectory(catalogUrl, this.lbl_Title.Text, contentUrl);
            ps.MessageBoxClose();
        }
        /// <summary>
        /// 后台查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SoContentData();
        }


        /// <summary>
        /// //设置字体
        /// </summary>
        private void Btn_Set_Click(object sender, EventArgs e)
        {
            ftDialog.ShowColor = true;
            ftDialog.ShowDialog();
            this.txt_Content.Font = ftDialog.Font;
            this.txt_Content.ForeColor = ftDialog.Color;
            xmlService.SaveSetUpXml(ftDialog.Font, ftDialog.Color);
        }

        #region 设置行间距
        public const int WM_USER = 0x0400;
        public const int EM_GETPARAFORMAT = WM_USER + 61;
        public const int EM_SETPARAFORMAT = WM_USER + 71;
        public const long MAX_TAB_STOPS = 32;
        public const uint PFM_LINESPACING = 0x00000100;
        [StructLayout(LayoutKind.Sequential)]
        private struct RowSpacing
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref RowSpacing lParam);

        //height：要指定的行高像素
        private void SetLineSpace(Control ctl, int height)
        {
            //1像素=15缇。
            int dyLineSpacing = height * 15;
            //4:dylinespace成员以  缇。的形式指定从一行到下一行的间距。控件使用指定的精确间距，即使dylinespace指定的值小于单个间距。
            //3:dylinespace成员以  缇。的形式指定从一行到下一行的间隔。但是，如果dylinespace指定的值小于单间距，则控件将显示单间距文本。
            byte bLineSpacingRule = (byte)3;
            RowSpacing fmt = new RowSpacing();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = bLineSpacingRule;
            fmt.dyLineSpacing = dyLineSpacing;
            fmt.dwMask = PFM_LINESPACING;
            try
            {
                SendMessage(new HandleRef(ctl, ctl.Handle), EM_SETPARAFORMAT, bLineSpacingRule, ref fmt);
            }
            catch
            { }
        }
        #endregion 设置行间距

        // 加大间距
        private void Lkbtn_RowLarge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int rowSpacing = xmlService.ObtainRowSpacing();
            SetLineSpace(txt_Content, rowSpacing + 1);
            xmlService.SaveRowSpacing(rowSpacing + 1);
        }

        // 缩小间距
        private void Lkbtn_RowSmall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int rowSpacing = xmlService.ObtainRowSpacing();
            SetLineSpace(txt_Content, rowSpacing - 1);
            xmlService.SaveRowSpacing(rowSpacing - 1);
        }

        private void LinkYellow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txt_Content.BackColor = ColorTranslator.FromHtml("#FAF9DE");
            xmlService.SaveBackgroundColor(ColorTranslator.FromHtml("#FAF9DE"));
        }

        /// <summary>
        /// 设置样式
        /// </summary>
        private void SetStyle() {
            //设置间距
            int rowSpacing = xmlService.ObtainRowSpacing();
            SetLineSpace(txt_Content, rowSpacing);
            //设置背景色
            this.txt_Content.BackColor = xmlService.ObtainBackgroundColor();
            //设置字体及前景色
            this.txt_Content.Font = xmlService.ObtainFont();
            this.txt_Content.ForeColor = xmlService.ObtainForeColor();
        }

        // 返回
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (catalogUrl == "")
                return;
            SoTitle objForm = new SoTitle()
            {
                sFrom = sFrom,
                bookName = bookName,
                titleUrl = catalogUrl
            };
            //再主窗体中加载  章节窗体
            sFrom?.Invoke(objForm);
            this.Close();
        }

        // 自定义背景色
        private void LkColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                Color color = ColorTranslator.FromHtml("#" + txtColor.Text.Trim().Replace("#", ""));
                this.txt_Content.BackColor = color;
                xmlService.SaveBackgroundColor(color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("颜色格式不正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 页面初次加载
        private void SoContent_Shown(object sender, EventArgs e)
        {
            LoadQuery();
        }
        public string  titleName="",content="";

        // 划水模式
        private void BtnHuaShui_Click(object sender, EventArgs e)
        {
            HideFrom hide = new HideFrom(this)
            {
                pShow = pShow
            };
            hide.Show();
            pShow(true);
        }

        // 获取章节内容数据并更新历史记录
        private void SoContentData()
        {
            if (contentUrl == "")
            {
                this.txt_Content.Text = "内容地址丢失";
                return;
            }
            
            string Html = HttpHelper.GetWebHtml("https://www.biqukan.com" + contentUrl, null);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Html);
            HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//div[@id='content']");
            titleName = "";
            titleName = doc.DocumentNode.SelectSingleNode("//div[@class='content']").SelectNodes("h1")[0].InnerText;
            content = "";
            content = headNode.InnerHtml.Replace("&nbsp;", "");
            content = content.Replace("<script>app2();</script><br><script>read2();</script>", "");
            content = content.Replace("<br><br>", "    \r\n");
            content = content.Replace("<br>", "        ");
        }
    }
}
