using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        Color bg;
        Panel[,] feld = new Panel[5, 12];
        public Form1()
        {
            InitializeComponent();
            for (int b = 0; b < 12; b++)
            {
                for (int c = 0; c < 5; c++)
                {
                    feld[c, b] = new Panel();
                    feld[c, b].Width = 29;
                    feld[c, b].Height = 29;
                    feld[c, b].Left = 9 + c * 40;
                    feld[c, b].Top = 460 - b * 40;
                    feld[c, b].BorderStyle = BorderStyle.FixedSingle;
                    feld[c, b].Parent = this;
                    feld[c, b].Click += panel9_Click;
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            bg = panel1.BackColor;
            int a1 = 1;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            bg = panel2.BackColor;
            int a2 = 2;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            bg = panel3.BackColor;
            int a3 = 3;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            bg = panel4.BackColor;
            int a4 = 4;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            bg = panel5.BackColor;
            int a5 = 5;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            bg = panel6.BackColor;
            int a6 = 6;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            bg = panel7.BackColor;
            int a7 = 7;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            bg = panel8.BackColor;
            int a8 = 8;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = bg;
        }
    }
}
