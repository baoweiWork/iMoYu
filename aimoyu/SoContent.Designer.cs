namespace aimoyu
{
    partial class SoContent
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Row = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkbtn_RowLarge = new System.Windows.Forms.LinkLabel();
            this.lkbtn_RowSmall = new System.Windows.Forms.LinkLabel();
            this.btn_Set = new System.Windows.Forms.Button();
            this.ftDialog = new System.Windows.Forms.FontDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(100, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "上一章";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Previous_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(258, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "下一章";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Next_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(195, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(40, 16);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "标题";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Row
            // 
            this.lbl_Row.AutoSize = true;
            this.lbl_Row.Location = new System.Drawing.Point(96, 9);
            this.lbl_Row.Name = "lbl_Row";
            this.lbl_Row.Size = new System.Drawing.Size(35, 12);
            this.lbl_Row.TabIndex = 7;
            this.lbl_Row.Text = "行距:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "背景色:";
            // 
            // lkbtn_RowLarge
            // 
            this.lkbtn_RowLarge.AutoSize = true;
            this.lkbtn_RowLarge.Location = new System.Drawing.Point(128, 9);
            this.lkbtn_RowLarge.Name = "lkbtn_RowLarge";
            this.lkbtn_RowLarge.Size = new System.Drawing.Size(29, 12);
            this.lkbtn_RowLarge.TabIndex = 9;
            this.lkbtn_RowLarge.TabStop = true;
            this.lkbtn_RowLarge.Text = "加大";
            this.lkbtn_RowLarge.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lkbtn_RowLarge_LinkClicked);
            // 
            // lkbtn_RowSmall
            // 
            this.lkbtn_RowSmall.AutoSize = true;
            this.lkbtn_RowSmall.Location = new System.Drawing.Point(164, 9);
            this.lkbtn_RowSmall.Name = "lkbtn_RowSmall";
            this.lkbtn_RowSmall.Size = new System.Drawing.Size(29, 12);
            this.lkbtn_RowSmall.TabIndex = 10;
            this.lkbtn_RowSmall.TabStop = true;
            this.lkbtn_RowSmall.Text = "缩小";
            this.lkbtn_RowSmall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lkbtn_RowSmall_LinkClicked);
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(12, 4);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 12;
            this.btn_Set.Text = "页面设置";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(275, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "杏仁黄";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(401, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 12);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "颜色自定义";
            // 
            // txt_Content
            // 
            this.txt_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Content.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Content.Location = new System.Drawing.Point(2, 51);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_Content.Size = new System.Drawing.Size(466, 461);
            this.txt_Content.TabIndex = 0;
            this.txt_Content.Text = "";
            // 
            // SoContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 555);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.lkbtn_RowSmall);
            this.Controls.Add(this.lkbtn_RowLarge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Row);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Content);
            this.Name = "SoContent";
            this.Text = "爱阅读";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Row;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lkbtn_RowLarge;
        private System.Windows.Forms.LinkLabel lkbtn_RowSmall;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.FontDialog ftDialog;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.RichTextBox txt_Content;
    }
}