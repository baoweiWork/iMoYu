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

namespace aimoyu.UI
{
    public partial class loading : Form
    {

        public loading()
        {
            InitializeComponent();
        }
        
        public string lMessage { get; set; }
        public int interval { get; set; }
        public Point messagePoint { get; set; }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Location = new Point(messagePoint.X + 120, messagePoint.Y + 90);
            this.Size = new Size(lbl_text.Size.Width + 25, 40);
            lbl_text.Text = lMessage.Trim();
            timer.Interval = interval;
            timer.Start();
        }
    }
}
