using aimoyu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI
{
    public partial class HideFrom : Form
    {
        public HideFrom(SoContent content)
        {
            InitializeComponent();
            ContentFrom = content;
        }
        //实例化一个委托
        public parentShow pShow;

        // 内容窗体 
        public static SoContent ContentFrom { get; set; }

        private bool bol = false;

        // 返回正常页面
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            pShow(false);
            bol = true;
            this.Close();
        }

        //下一页
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ContentFrom == null)
                return;
            int sy = ContentFrom.chapterList.FindIndex(n => n == ContentFrom.contentUrl);
            if (sy == ContentFrom.chapterList.Count())
            {
                MessageBox.Show("已到达末章", "提示", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.txt_Content.Text = "";
                ContentFrom.contentUrl = ContentFrom.chapterList[sy + 1].ToString();
                ContentFrom.LoadQuery(false);
                this.txt_Content.Text = ContentFrom.lbl_Title.Text+ "\r\n" + ContentFrom.txt_Content.Text;
            }
        }

        private int xvalues, yvalues;
        private void HideFrom_Shown(object sender, EventArgs e)
        {
            XmlServices xmlService = new XmlServices();
            this.txt_Content.Text = ContentFrom.lbl_Title.Text + "\r\n" + ContentFrom.txt_Content.Text;
            this.txt_Content.BackColor = xmlService.ObtainBackgroundColor();
            //设置字体及前景色
            this.txt_Content.Font = xmlService.ObtainFont();
            this.txt_Content.ForeColor = xmlService.ObtainForeColor();
            this.Resize += new EventHandler(MainForm_Resize); //添加窗体拉伸重绘事件
            xvalues = this.Width;//记录窗体初始大小
            yvalues = this.Height;
            SetTag(this);
        }
        // 关闭该窗体时结束整个程序
        private void HideFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!bol)
            Environment.Exit(0);
        }
        #region 去除窗体边框后，可以改变窗体尺寸
        //定义用于设置的常量值
        const int Guying_HTLEFT = 10;
        const int Guying_HTRIGHT = 11;
        const int Guying_HTTOP = 12;
        const int Guying_HTTOPLEFT = 13;
        const int Guying_HTTOPRIGHT = 14;
        const int Guying_HTBOTTOM = 15;
        const int Guying_HTBOTTOMLEFT = 0x10;
        const int Guying_HTBOTTOMRIGHT = 17;
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HT_CAPTION = 0x2;
        //重写系统WndProc函数：
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
                        else m.Result = (IntPtr)Guying_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)Guying_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)Guying_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)Guying_HTBOTTOM;
                    break;
                case 0x0201: //鼠标左键按下的消息
                    m.Msg = 0x00A1; //更改消息为非客户区按下鼠标
                    m.LParam = IntPtr.Zero; //默认值
                    m.WParam = new IntPtr(2); //鼠标放在标题栏内
                    base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private void HideFrom_MouseDown(object sender, MouseEventArgs e)
        {
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref msg);
        }

        #endregion

        #region 窗体拉伸重绘事件，窗体自适应屏幕尺寸，依旧屏幕自动缩放
        private void SetControls(float newX, float newY, Control cons)//改变控件的大小
        {
            foreach (Control con in cons.Controls)
            {
                if (con != txt_Content && con != btnNext && con != btnReturn)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = Convert.ToSingle(mytag[0]) * newX;
                    con.Width = (int)a;
                    a = Convert.ToSingle(mytag[1]) * newY;
                    con.Height = (int)a;
                    a = Convert.ToSingle(mytag[2]) * newX;
                    con.Left = (int)a;
                    a = Convert.ToSingle(mytag[3]) * newY;
                    con.Top = (int)a;
                    Single currentSize = Convert.ToSingle(mytag[4]) * newY;

                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        SetControls(newX, newY, con);
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)//重绘事件
        {
            if (xvalues == 0 || yvalues == 0)
                return;
            float newX = this.Width / xvalues;//获得比例
            float newY = this.Height / yvalues;
            SetControls(newX, newY, this);
        }


        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)  //遍历窗体中的控件,记录控件初始大小
            {
                if (con != txt_Content)
                {
                    con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                    if (con.Controls.Count > 0)
                    {
                        SetTag(con);
                    }
                }
            }
        }

        #endregion
    }
}
