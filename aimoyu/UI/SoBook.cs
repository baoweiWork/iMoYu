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
using System.Xml;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI
{
    public partial class SoBook : Form
    {
        public SoBook()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// 搜索书名
        /// </summary>
        public string bookName = "";

        //实例化一个委托
        public showForm sFrom;
        //实例化一个委托
        public parentShow pShow;
        PublicServices ps = new PublicServices();
        // 搜索
        private void BtnSearck_Click(object sender, EventArgs e)
        {
            try
            {
                
                ps.MessageBoxShow(this.PointToScreen(new Point(0, 0)));
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += BgWorker_DoWork;
                bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
                bgWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// 数据查询之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var item in listView)
            {
                this.listBook.Items.Add(item);
            }
            listView = null;
            ps.MessageBoxClose();
        }
        /// <summary>
        /// 后台查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SoBookData();
        }

        // 选中行更改
        private void ListTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.listBook.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string stitleName = this.listBook.Items[index].SubItems[1].Text;//书名
                    string sPartName = this.listBook.Items[index].SubItems[3].Text;//目录地址
                    XmlServices.AddHomeDirectory(stitleName, sPartName);
                    SoTitle objForm = new SoTitle()
                    {
                        titleUrl = sPartName,
                        bookName = this.txtBookName.Text,
                        sFrom = sFrom,
                        pShow=pShow
                    };
                    this.Close();
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        // 页面加载
        private void SoBook_Shown(object sender, EventArgs e)
        {
            if (bookName != "")
            {
                this.txtBookName.Text = bookName;
                BtnSearck_Click(sender, e);
            }
        }

        private List<ListViewItem> listView = new List<ListViewItem>();

        // 搜索数据
        private void SoBookData()
        {
            var title = this.txtBookName.Text;
            string url = "https://so.biqusoso.com/s.php?ie=utf-8&siteid=biqukan.com&q=" + title;
            HtmlWeb web = new HtmlWeb();
            //从url中加载
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//ul");
            HtmlNodeCollection aCollection = headNode.SelectNodes("li");
            if (aCollection.Count <= 0)
                return;
            aCollection.RemoveAt(0);
            foreach (var item in aCollection)
            {
                ListViewItem tt = new ListViewItem();
                tt.SubItems[0].Text = item.SelectNodes("span")[0].InnerText;
                tt.SubItems.Add(item.SelectNodes("span")[1].InnerText);
                tt.SubItems.Add(item.SelectNodes("span")[2].InnerText);
                tt.SubItems.Add(item.SelectNodes("span")[1].SelectNodes("a")[0].Attributes["href"].Value);
                listView.Add(tt);
            }
        }
    }
}
