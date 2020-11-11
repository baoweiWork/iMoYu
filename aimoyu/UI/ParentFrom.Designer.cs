namespace aimoyu.UI
{
    partial class ParentFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentFrom));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("我要搜书");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("我的书架");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("历史记录");
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeTitle = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spContainer
            // 
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.Location = new System.Drawing.Point(0, 0);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.label1);
            this.spContainer.Panel1.Controls.Add(this.pictureBox1);
            this.spContainer.Panel1.Controls.Add(this.treeTitle);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Size = new System.Drawing.Size(800, 509);
            this.spContainer.SplitterDistance = 143;
            this.spContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "版本:20.11.11.01";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(3, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 21);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // treeTitle
            // 
            this.treeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeTitle.Location = new System.Drawing.Point(0, 1);
            this.treeTitle.Name = "treeTitle";
            treeNode1.Name = "soBook";
            treeNode1.Text = "我要搜书";
            treeNode2.Name = "myBook";
            treeNode2.Text = "我的书架";
            treeNode3.Name = "historyBook";
            treeNode3.Text = "历史记录";
            this.treeTitle.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeTitle.Size = new System.Drawing.Size(140, 509);
            this.treeTitle.TabIndex = 1;
            this.treeTitle.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeTitle_NodeMouseClick);
            // 
            // ParentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParentFrom";
            this.Text = "爱摸鱼";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParentFrom_FormClosed);
            this.Resize += new System.EventHandler(this.ParentFrom_Resize);
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.TreeView treeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}