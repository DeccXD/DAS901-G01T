using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_DAS
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (this.Opacity > 0)
            {
                this.Opacity -= 0.0001;

            }
            this.Hide();
            Form1 login = new Form1();
            login.Show();
            timer1.Stop();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 15000;
        }
    }
}
