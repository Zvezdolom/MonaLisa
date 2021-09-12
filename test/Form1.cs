using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private static int[] Array;
        private static int _Width = 56;
        private static int _Height = 80;
        private static int _Size = 10;

        public Form1()
        {
            InitializeComponent();
            ReadData();
            this.Width = 585;
            this.Height = 850;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            
            for (int Y = 1; Y < _Height; Y++)
                for (int X = 1; X < _Width; X++)
                    if (Array[(Y-1) * _Width + X - 1] == 1)
                        g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(X* _Size, Y* _Size, _Size, _Size));
        }

        private void ReadData()
        {
            string path = "../../data.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string[] Data = sr.ReadToEnd().Split(new char[] { ',' });
                Array = new int[Data.Length];
                for (int i = 0; i < Data.Length; i++)
                    Array[i] = Convert.ToInt32(Data[i]);
            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
