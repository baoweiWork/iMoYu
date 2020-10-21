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
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.loading;
using static aimoyu.ParentFrom;

namespace aimoyu
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
        private void SoHistory_Load(object sender, EventArgs e)
        {
            try
            {
                PublicServices.MessageBoxShow();
                this.listTitle.Items.Clear();

                var list = XmlServices.GetAllChapter();
                int i = 1;
                foreach (var item in list)
                {
                    ListViewItem tt = new ListViewItem();
                    tt.SubItems[0].Text = i.ToString();
                    tt.SubItems.Add(item.title);
                    tt.SubItems.Add(item.path);
                    tt.SubItems.Add(item.history);
                    tt.SubItems.Add(item.historyurl);
                    this.listTitle.Items.Add(tt);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void listTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedIndexCollection indexes = this.listTitle.SelectedIndices;
            if (indexes.Count > 0)
            {
                PublicServices.MessageBoxShow();
                int index = indexes[0];
                string pathurl = this.listTitle.Items[index].SubItems[2].Text;//获取第3列的值
                string pathurls = this.listTitle.Items[index].SubItems[4].Text;//获取第5列的值
                if (!string.IsNullOrWhiteSpace(pathurls))
                {
                    string Html = HttpHelper.GetWebHtml(pathurl, null);
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(Html);

                    HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//dl");

                    HtmlNodeCollection aCollection = headNode.SelectNodes("dd");
                    List<string> zhangjielist = new List<string>();

                    foreach (var item in aCollection)
                    {
                        zhangjielist.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
                    }
                    this.Close();
                    SoContent objForm = new SoContent(pathurl, pathurls, zhangjielist);
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }
                else
                {
                    this.Close();
                    SoTitle objForm = new SoTitle(pathurl);
                    objForm.sFrom = sFrom;
                    //再主窗体中加载  章节窗体
                    sFrom?.Invoke(objForm);
                }

            }
        }
    }
}
