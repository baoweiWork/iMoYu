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
            this.treeTitle = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.SuspendLayout();
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
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Size = new System.Drawing.Size(800, 509);
            this.spContainer.SplitterDistance = 143;
            this.spContainer.TabIndex = 0;
            // 
            // treeTitle
            // 
            this.treeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeTitle.Location = new System.Drawing.Point(3, 3);
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
            this.treeTitle.Size = new System.Drawing.Size(134, 503);
            this.treeTitle.TabIndex = 1;
            this.treeTitle.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeTitle_NodeMouseClick);
            // 
            // ParentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.treeTitle);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "ParentFrom";
            this.Text = "爱摸鱼";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParentFrom_FormClosed);
            this.Resize += new System.EventHandler(this.ParentFrom_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.TreeView treeTitle;
    }
}