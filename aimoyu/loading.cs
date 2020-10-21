using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aimoyu
{
    public partial class loading : Form
    {
        public loading()
        {
            
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterParent;
        }
        public string lMessage { get; set; }
        public int interval { get; set; }
        //委托方法



        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            lbl_text.Text = lMessage.Trim();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(lbl_text.Size.Width + 25, 40);

            timer.Interval = interval;
            timer.Start();
        }
    }
}
