namespace aimoyu.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoContent));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Row = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkbtn_RowLarge = new System.Windows.Forms.LinkLabel();
            this.lkbtn_RowSmall = new System.Windows.Forms.LinkLabel();
            this.btn_Set = new System.Windows.Forms.Button();
            this.ftDialog = new System.Windows.Forms.FontDialog();
            this.LinkYellow = new System.Windows.Forms.LinkLabel();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lkColor = new System.Windows.Forms.LinkLabel();
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.btnReturn = new System.Windows.Forms.Button();
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
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(199, 35);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(42, 16);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "标题";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Row
            // 
            this.lbl_Row.AutoSize = true;
            this.lbl_Row.Location = new System.Drawing.Point(123, 11);
            this.lbl_Row.Name = "lbl_Row";
            this.lbl_Row.Size = new System.Drawing.Size(35, 12);
            this.lbl_Row.TabIndex = 7;
            this.lbl_Row.Text = "行距:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "背景色:";
            // 
            // lkbtn_RowLarge
            // 
            this.lkbtn_RowLarge.AutoSize = true;
            this.lkbtn_RowLarge.Location = new System.Drawing.Point(155, 11);
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
            this.lkbtn_RowSmall.Location = new System.Drawing.Point(191, 11);
            this.lkbtn_RowSmall.Name = "lkbtn_RowSmall";
            this.lkbtn_RowSmall.Size = new System.Drawing.Size(29, 12);
            this.lkbtn_RowSmall.TabIndex = 10;
            this.lkbtn_RowSmall.TabStop = true;
            this.lkbtn_RowSmall.Text = "缩小";
            this.lkbtn_RowSmall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lkbtn_RowSmall_LinkClicked);
            // 
            // btn_Set
            // 
            this.btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Set.Location = new System.Drawing.Point(41, 6);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 12;
            this.btn_Set.Text = "页面设置";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // LinkYellow
            // 
            this.LinkYellow.AutoSize = true;
            this.LinkYellow.Location = new System.Drawing.Point(286, 11);
            this.LinkYellow.Name = "LinkYellow";
            this.LinkYellow.Size = new System.Drawing.Size(41, 12);
            this.LinkYellow.TabIndex = 13;
            this.LinkYellow.TabStop = true;
            this.LinkYellow.Text = "杏仁黄";
            this.LinkYellow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkYellow_LinkClicked);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(336, 7);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(56, 21);
            this.txtColor.TabIndex = 14;
            // 
            // lkColor
            // 
            this.lkColor.AutoSize = true;
            this.lkColor.Location = new System.Drawing.Point(398, 11);
            this.lkColor.Name = "lkColor";
            this.lkColor.Size = new System.Drawing.Size(65, 12);
            this.lkColor.TabIndex = 15;
            this.lkColor.TabStop = true;
            this.lkColor.Text = "颜色自定义";
            this.lkColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkColor_LinkClicked);
            // 
            // txt_Content
            // 
            this.txt_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Content.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Content.Location = new System.Drawing.Point(2, 57);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_Content.Size = new System.Drawing.Size(466, 455);
            this.txt_Content.TabIndex = 0;
            this.txt_Content.Text = "";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(5, 6);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(30, 23);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // SoContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 555);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lkColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.LinkYellow);
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
            this.Shown += new System.EventHandler(this.SoContent_Shown);
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
        private System.Windows.Forms.LinkLabel LinkYellow;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.LinkLabel lkColor;
        private System.Windows.Forms.RichTextBox txt_Content;
        private System.Windows.Forms.Button btnReturn;
    }
}