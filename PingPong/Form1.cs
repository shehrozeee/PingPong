using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int step = 10;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - step);
            }
            else if (e.KeyCode == Keys.Down)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + step);
            }
        }

        float speedX=3.2f, speedY=3.2f;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X+(int)speedX, pictureBox1.Location.Y+(int)speedY);
        }
    }
}
