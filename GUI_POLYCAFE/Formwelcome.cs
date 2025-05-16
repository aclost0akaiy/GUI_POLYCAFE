using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_POLYCAFE
{
    public partial class Formwelcome : Form
    {
        
        public Formwelcome()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.Visible = false;
                        Form1 login = new Form1();
                        login.Show();
                        this.Hide();
                    }));
                }
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Formwelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
