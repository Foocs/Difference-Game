using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Joc_1
{
    public partial class Form2 : Form
    {
        int i = 0, time = 0;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox currentPic = sender as PictureBox;
            if (timer1.Enabled)
            {
                if ((string)currentPic.Tag != "Picture found")
                {
                    label1.Text = "Diferențe găsite: " + (++i) + "/10";
                    currentPic.Tag = "Picture found";
                }
                currentPic.Image = Properties.Resources._391194_circle_vector_png;
                if (i == 10)
                {
                    MessageBox.Show("Felicitări!", "Bravo!");
                    Form1 f = new Form1();
                    this.Hide();
                    f.Show();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++time <= 300)
                label2.Text = "Timp rămas: " + ((time / 60) % 60).ToString("00") + ":" + (time % 60).ToString("00");
            else
            {
                timer1.Stop();
                MessageBox.Show("Ai pierdut!", ":(");
            }
        }
    }
}
