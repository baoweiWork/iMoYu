namespace aimoyu.UI
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
            this.listTitle = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historyurl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // listTitle
            // 
            this.listTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTitle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.History,
            this.Path,
            this.Historyurl});
            this.listTitle.Location = new System.Drawing.Point(0, -2);
            this.listTitle.Name = "listTitle";
            this.listTitle.ReadOnly = true;
            this.listTitle.RowTemplate.Height = 23;
            this.listTitle.Size = new System.Drawing.Size(707, 452);
            this.listTitle.TabIndex = 5;
            this.listTitle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListTitle_CellContentClick);
            this.listTitle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ListTitle_RowPostPaint);
            // 
            // ID
            // 
            this.ID.HeaderText = "序号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "书名";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // History
            // 
            this.History.DataPropertyName = "History";
            this.History.HeaderText = "最近浏览章节";
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.Width = 300;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "链接地址";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // Historyurl
            // 
            this.Historyurl.DataPropertyName = "Historyurl";
            this.Historyurl.HeaderText = "章节地址";
            this.Historyurl.Name = "Historyurl";
            this.Historyurl.ReadOnly = true;
            this.Historyurl.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.listTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Historyurl;
    }
}