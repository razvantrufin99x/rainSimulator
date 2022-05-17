using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace rainSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Font f;
        public Pen p = new Pen(Color.Black, 1);
        public Brush b = new SolidBrush(Color.Black);

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            f = this.Font;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {

                g.DrawEllipse(p, e.X-(i), e.Y - (i), i*2, i*2);
                Thread.Sleep(50);
                g.Clear(this.BackColor);

            }
            g.Clear(this.BackColor);

        }
    }
}
