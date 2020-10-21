using aimoyu.DbHelp;
using aimoyu.Services;
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
        List<string> titleList = new List<string>();
        /// <summary>
        /// 章节URL
        /// </summary>
        public string titleUrl = "";
        /// <summary>
        /// 搜索书名
        /// </summary>
        public string bookName = "";
        //实例化一个委托
        public showForm sFrom;
        public SoTitle(string url)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            PublicServices.MessageBoxShow();
            titleUrl = url;
            load(url);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.listView1.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string sPartNames = this.listView1.Items[index].SubItems[1].Text;//获取第2列的值
                    string sPartName = this.listView1.Items[index].SubItems[2].Text;//获取第3列的值
                    XmlServices.EditViceDirectory(titleUrl, sPartNames, sPartName);
                    this.Close();
                    SoContent objForm = new SoContent(titleUrl, sPartName, titleList)
                    {
                        titleUrl = titleUrl,
                        sFrom = sFrom,
                        bookName = bookName
                    };
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
                    titleList.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
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

        // 返回
        private void ToolBtnReturn_Click(object sender, EventArgs e)
        {
            if (bookName == "")
                return;
            SoBook objForm = new SoBook
            {
                sFrom = sFrom,
                bookName = bookName
            };
            this.Close();
            //再主窗体中加载  章节窗体
            sFrom?.Invoke(objForm);
        }
    }
}
