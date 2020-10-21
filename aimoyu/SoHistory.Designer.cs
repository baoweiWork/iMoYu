namespace aimoyu
{
    partial class SoHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTitle = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chaptername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chapteraddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listTitle
            // 
            this.listTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTitle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.bookname,
            this.url,
            this.Chaptername,
            this.Chapteraddress});
            this.listTitle.FullRowSelect = true;
            this.listTitle.GridLines = true;
            this.listTitle.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listTitle.HideSelection = false;
            this.listTitle.Location = new System.Drawing.Point(2, 0);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(704, 438);
            this.listTitle.TabIndex = 4;
            this.listTitle.UseCompatibleStateImageBehavior = false;
            this.listTitle.View = System.Windows.Forms.View.Details;
            this.listTitle.SelectedIndexChanged += new System.EventHandler(this.listTitle_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "序号";
            this.number.Width = 40;
            // 
            // bookname
            // 
            this.bookname.Text = "书名";
            this.bookname.Width = 100;
            // 
            // url
            // 
            this.url.Text = "链接地址";
            this.url.Width = 200;
            // 
            // Chaptername
            // 
            this.Chaptername.Text = "最近浏览章节";
            this.Chaptername.Width = 150;
            // 
            // Chapteraddress
            // 
            this.Chapteraddress.Text = "章节地址";
            this.Chapteraddress.Width = 200;
            // 
            // SoHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.listTitle);
            this.Name = "SoHistory";
            this.Text = "历史记录";
            this.Load += new System.EventHandler(this.SoHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listTitle;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.ColumnHeader Chaptername;
        private System.Windows.Forms.ColumnHeader Chapteraddress;
    }
}