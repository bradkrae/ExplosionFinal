using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Explosion
{
    public partial class Form1 : Form
    {
        Graphics g;
       
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Explosion(40, 40, 130);
        }

        public void Explosion(float x, float y, float pixels)
        {
            float scale = pixels / 130;
            Pen exPen = new Pen(Color.Red);
            Pen exPen1 = new Pen(Color.Yellow);

            //g.DrawRectangle(exPen, x + (0 * scale), y + (0 * scale), (130 * scale), (130 * scale));
            g.DrawArc(exPen1, x + (0 * scale), y + (0 * scale), (130 * scale), (130 * scale), 270, 360);
            g.DrawLine(exPen, x + (25 * scale), y + (25 * scale), x + (105 * scale), y + (105 * scale));
            g.DrawLine(exPen, x + (25 * scale), y + (105 * scale), x + (105 * scale), y + (25 * scale));
            g.DrawLine(exPen, x + (65 * scale), y + (5 * scale), x + (65 * scale), y + (125 * scale));
            g.DrawLine(exPen, x + (5 * scale), y + (65 * scale), x + (125 * scale), y + (65 * scale));
            g.DrawArc(exPen1, x + (5 * scale), y + (5 * scale), (10 * scale), (10 * scale), 270, 360);
            g.DrawArc(exPen1, x + (5 * scale), y + (115 * scale), (10 * scale), (10 * scale), 270, 360);
            g.DrawArc(exPen1, x + (115 * scale), y + (115 * scale), (10 * scale), (10 * scale), 270, 360);
            g.DrawArc(exPen1, x + (115 * scale), y + (5 * scale), (10 * scale), (10 * scale), 270, 360);




        }

    }
}


