using aimoyu.DbHelp;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.ParentFrom;

namespace aimoyu
{
    public partial class SoTitle : Form
    {
        List<string> zhangjielist = new List<string>();
        loading loading = new loading();
        //实例化一个委托
        public showForm sFrom;
        public SoTitle(string url)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loading.Show();
            load(url);
            loading.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.listView1.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string sPartName = this.listView1.Items[index].SubItems[2].Text;//获取第4列的值
                    this.Close();
                    SoContent objForm = new SoContent(sPartName, zhangjielist);
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

        public void load(string url)
        {
            try
            {
                string Html = HttpHelper.GetWebHtml(url, null);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(Html);
                HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//dl");
                HtmlNodeCollection aCollection = headNode.SelectNodes("dd");
                int i = 1;
                foreach (var item in aCollection)
                {
                    ListViewItem tt = new ListViewItem();
                    
                    tt.SubItems[0].Text=i.ToString();
                    tt.SubItems.Add(item.InnerText);
                    tt.SubItems.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
                    zhangjielist.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
                    this.listView1.Items.Add(tt);
                    i++;
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
