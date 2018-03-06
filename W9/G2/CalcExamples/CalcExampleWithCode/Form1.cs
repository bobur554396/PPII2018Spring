using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcExampleWithCode
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
                    btn.Name = "button" + cnt;
                    btn.Text = cnt.ToString();
                    btn.Size = new Size(50, 50);
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.Blue;
                    btn.Location = new Point(j * 50, i * 50);
                    btn.Click += numbers_click;

                    Controls.Add(btn);

                    cnt++;
                }
            }
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }
    }
}
