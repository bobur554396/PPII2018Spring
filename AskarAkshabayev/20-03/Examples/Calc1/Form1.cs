using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cnt = 1;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = cnt+"";
                    btn.Font = new Font(FontFamily.GenericSerif, 20);
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(i * 60 + 100, j * 60 + 100);

                    btn.Click += mybutton_click;

                    Controls.Add(btn);

                    cnt++;
                }
            }

        }

        private void mybutton_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
    }
}
