using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Blue, 0, 0, Width, Height);

            Font f = new Font(FontFamily.GenericSansSerif, 20);
            Brush b = new SolidBrush(Color.Red);

            e.Graphics.DrawString("hello", f, b, 50, 50);
        }
    }
}
