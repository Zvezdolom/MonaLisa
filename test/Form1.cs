using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int[] Array = new int[]{
            1,1,1,1,
            0,0,0,0,
            1,1,1,1,
            0,0,0,0
        };

        public static int _Width = 4;
        public static int _Height = 4;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int Y = 0; Y < _Height; Y++)
            {
                for (int X = 1; X < _Width; X++)
                {
                    if (Array[])
                    {

                    }
                    g.DrawLine(new Pen(Brushes.Black, 3), i, j, i+2, j+2);
                }
            }
            
        }
    }
}
