using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Rectangle r = new Rectangle(100, 100, 300, 300);
            e.Graphics.FillRectangle(brush, r);

            Pen p = new Pen(Color.Green, 5);
            e.Graphics.DrawRectangle(p, r);

            Font f = new Font(FontFamily.GenericSerif, 20);
            string s = "hello";
            e.Graphics.DrawString(s, f, brush, 20, 20);
        }
    }
}
