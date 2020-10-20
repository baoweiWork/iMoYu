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
using System.Xml;
using static aimoyu.ParentFrom;

namespace aimoyu
{
    public partial class SoBook : Form
    {
        loading loading = new loading();
        public SoBook()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        //实例化一个委托
        public showForm sFrom;
        private void btnSearck_Click(object sender, EventArgs e)
        {
            try
            {
                loading.Show();
                this.listTitle.Items.Clear();
                var title = this.textBox1.Text;
                string url = "https://so.biqusoso.com/s.php?ie=utf-8&siteid=biqukan.com&q=" + title;
                HtmlWeb web = new HtmlWeb();
                //从url中加载
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//ul");
                HtmlNodeCollection aCollection = headNode.SelectNodes("li");
                int i = 0;
                foreach (var item in aCollection)
                {
                    if (i == 0)
                    {
                        i++;
                        continue;
                    }
                    ListViewItem tt = new ListViewItem();
                    tt.SubItems[0].Text = item.SelectNodes("span")[0].InnerText;
                    //tt.SubItems.Add(item.SelectNodes("span")[0].InnerText);
                    tt.SubItems.Add(item.SelectNodes("span")[1].InnerText);
                    tt.SubItems.Add(item.SelectNodes("span")[2].InnerText);
                    tt.SubItems.Add(item.SelectNodes("span")[1].SelectNodes("a")[0].Attributes["href"].Value);
                    this.listTitle.Items.Add(tt);
                    i++;
                }
                loading.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败！\n" + ex.Message, "提示", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void listTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.listTitle.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string sPartName = this.listTitle.Items[index].SubItems[3].Text;//获取第4列的值

                    XmlDocument doc = new XmlDocument();//创建一个XML文档
                    XmlReaderSettings settings = new XmlReaderSettings();//设置读取XML时的属性。
                    settings.IgnoreComments = true;//XML忽略注释。

                    this.Close();
                    SoTitle objForm = new SoTitle(sPartName);
                    objForm.sFrom = sFrom;
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
    }
}
