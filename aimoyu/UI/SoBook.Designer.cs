﻿namespace aimoyu.UI
{
    partial class SoBook
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBook = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(42, 14);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(264, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearck_Click);
            // 
            // listBook
            // 
            this.listBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.bookname,
            this.name,
            this.url});
            this.listBook.FullRowSelect = true;
            this.listBook.GridLines = true;
            this.listBook.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBook.HideSelection = false;
            this.listBook.Location = new System.Drawing.Point(0, 42);
            this.listBook.Name = "listBook";
            this.listBook.Size = new System.Drawing.Size(715, 408);
            this.listBook.TabIndex = 3;
            this.listBook.UseCompatibleStateImageBehavior = false;
            this.listBook.View = System.Windows.Forms.View.Details;
            this.listBook.SelectedIndexChanged += new System.EventHandler(this.ListTitle_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "序号";
            // 
            // bookname
            // 
            this.bookname.Text = "书名";
            this.bookname.Width = 100;
            // 
            // name
            // 
            this.name.Text = "作者";
            this.name.Width = 100;
            // 
            // url
            // 
            this.url.Text = "链接地址";
            this.url.Width = 400;
            // 
            // SoBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.listBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Name = "SoBook";
            this.Text = "爱搜索";
            this.Shown += new System.EventHandler(this.SoBook_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listBook;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader url;
    }
}

