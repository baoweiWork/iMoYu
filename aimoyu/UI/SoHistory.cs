using aimoyu.DbHelp;
using aimoyu.Services;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI
{
    public partial class SoHistory : Form
    {
        public SoHistory()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //实例化一个委托
        public showForm sFrom;

        private List<string> zhangjielist = null;

        private void SoHistory_Load(object sender, EventArgs e)
        {
            try
            {
                PublicServices.MessageBoxShow(this.PointToScreen(new Point(0, 0)));
                var list = XmlServices.GetAllChapter();
                this.listTitle.RowHeadersVisible = false;
                this.listTitle.AutoGenerateColumns = false;
                this.listTitle.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        //单击历史列表内容时触发
        private void ListTitle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex =e.RowIndex;
            //1章节2内容
            int comIndex = e.ColumnIndex;
            if (rowindex > 0&& comIndex!=0)
            {
                PublicServices.MessageBoxShow(this.PointToScreen(new Point(0, 0)));
                string bookName = listTitle.CurrentRow.Cells["Title"].Value.ToString();//获取书名
                string pathurl = listTitle.CurrentRow.Cells["Path"].Value.ToString();//获取目录URL
                string contentUrl = listTitle.CurrentRow.Cells["Historyurl"].Value.ToString();//获取具体内容URL
                //目录章节
                if (comIndex==1)
                {
                    this.Close();
                    SoTitle objForm = new SoTitle()
                    {
                        sFrom = sFrom,
                        titleUrl= pathurl,
                        bookName= bookName
                    };
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }
                //具体内容
                else if(comIndex == 2)
                {
                    if (contentUrl == "")
                        return;
                    //创建TestClass类的对象 
                    ThreadServices threadClass = new ThreadServices()
                    {
                        //在testclass对象的mainThread(委托)对象上搭载方法，在线程中调用mainThread对象时相当于调用了这方法。 
                        mainThread = new ThreadServices.WebDataDelegate(GetChapterData)
                    };
                    //启动线程，启动之后线程才开始执行 
                    void starter() { threadClass.QueryData(pathurl); }
                    new Thread(starter).Start();
                    SoContent objForm = new SoContent
                    {
                        catalogUrl = pathurl,
                        contentUrl = contentUrl,
                        chapterList = zhangjielist,
                        bookName = bookName
                    };
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }
                this.Close();
            }
        }

        // 根据URL获取章节数据
        private void GetChapterData(string pathurl)
        {
            string Html = HttpHelper.GetWebHtml(pathurl, null);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Html);
            HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//dl");
            HtmlNodeCollection aCollection = headNode.SelectNodes("dd");
            zhangjielist = new List<string>();
            foreach (var item in aCollection)
            {
                zhangjielist.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
            }
        }

        //添加序号
        private void ListTitle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in listTitle.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }
    }
}
