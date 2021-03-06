﻿using aimoyu.DbHelp;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aimoyu.UI.ParentFrom;

namespace aimoyu.UI
{
    public partial class SoTitle : Form
    {
        /// <summary>
        /// 全部章节
        /// </summary>
        private readonly List<string> titleList = new List<string>();

        /// <summary>
        /// 章节URL
        /// </summary>
        public string titleUrl = "";

        /// <summary>
        /// 搜索书名
        /// </summary>
        public string bookName = "";

        // 实例化一个委托
        public showForm sFrom;
        //实例化一个委托
        public parentShow pShow;
        public SoTitle()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

        }

        // 选中行更改
        private void TitleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedIndexCollection indexes = this.TitleListView.SelectedIndices;
                if (indexes.Count > 0)
                {
                    int index = indexes[0];
                    string sPartNames = this.TitleListView.Items[index].SubItems[1].Text;//章节名称
                    string contentUrl = this.TitleListView.Items[index].SubItems[2].Text;//内容地址
                    XmlServices.EditViceDirectory(titleUrl, sPartNames, contentUrl);
                    this.Close();
                    SoContent objForm = new SoContent()
                    {
                        contentUrl = contentUrl,
                        catalogUrl= titleUrl,
                        sFrom = sFrom,
                        bookName = bookName,
                        chapterList = titleList,
                        pShow=pShow
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
        PublicServices ps = new PublicServices();
        // 初始加载
        private void SoTitle_Shown(object sender, EventArgs e)
        {
            try
            {
                if (titleUrl == "")
                {
                    MessageBox.Show("目录章节获取失败");
                    return;
                }
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
                this.TitleListView.Items.Add(item);
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
            SoTitleData();
        }

        private List<ListViewItem> listView=new List<ListViewItem>();

        // 获取目录章节数据
        private void SoTitleData() {
            string Html = HttpHelper.GetWebHtml(titleUrl, null);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Html);
            HtmlNode headNode = doc.DocumentNode.SelectSingleNode("//dl");
            HtmlNodeCollection aCollection = headNode.SelectNodes("dd");
            int k = 1;
            //前12条不展示
            for (int i = 0; i < 12; i++)
            {
                aCollection.Remove(0);
            }
            foreach (var item in aCollection)
            {
                ListViewItem tt = new ListViewItem();
                tt.SubItems[0].Text = k.ToString();
                tt.SubItems.Add(item.InnerText);
                tt.SubItems.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
                titleList.Add(item.SelectNodes("a")[0].Attributes["href"].Value);
                listView.Add(tt);
                k++;
            }
        }

        private void TitleListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //for (int i = list.Count; i >0 ; i--)
            //{
            //    this.TitleListView.Items.Add(list[i]);
            //}
        }
    }
}
