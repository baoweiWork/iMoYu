using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aimoyu.UI
{
    public partial class ParentFrom : Form
    {
        /// <summary>
        /// 记录当前加载的窗体
        /// </summary>
        public Form currentForm;
        //声明一个委托
        public delegate void showForm(Form frm);
   
        public ParentFrom()
        {
            InitializeComponent();
        }

        // 节点点击事件
        private void TreeTitle_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string name = e.Node.Name;
            if (name == "soBook")
            {
                SoBook objForm = new SoBook
                {
                    sFrom = this.ShowForm
                };
                ShowForm(objForm);
                currentForm = objForm;
            }
            else if (name == "myBook")
            {
                
            }
            else if (name == "historyBook")
            {
                SoHistory objForm = new SoHistory
                {
                    sFrom = this.ShowForm
                };
                ShowForm(objForm);
                currentForm = objForm;
            }
        }

        /// <summary>
        /// panel加载窗体
        /// </summary>
        private void ShowForm(Form frm)
        {
            lock (this)
            {
                try
                {
                    if (this.currentForm != null && this.currentForm == frm)
                    {
                        return;
                    }
                    else if (this.currentForm != null)
                    {
                        if (this.ActiveMdiChild != null)
                        {
                            this.ActiveMdiChild.Hide();
                        }
                    }
                    this.spContainer.Panel2.Controls.Clear();
                    this.currentForm = frm;
                    frm.MdiParent = this;
                    frm.TopLevel = false;//将子窗体设置成非顶级控件
                    frm.FormBorderStyle = FormBorderStyle.None;//去掉子窗体边框
                    frm.Parent = this.spContainer.Panel2;//指定子窗体显示的容器
                    frm.Dock = DockStyle.Fill;//设置子窗体随容器大小自动调整
                    frm.Show();
                    this.Refresh();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("窗体加载失败:"+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 调整空间大小时触发
        private void ParentFrom_Resize(object sender, EventArgs e)
        {
            this.spContainer.SplitterDistance = 140;
        }

        // 主窗体结束时关闭所有线程
        private void ParentFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
