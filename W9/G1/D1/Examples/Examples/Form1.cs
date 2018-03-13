using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("From load event");


            Width = 700;
            Height = 700;
            BackColor = Color.Blue;



            Button btn = new Button();
            btn.Text = "my button";
            btn.Size = new Size(300, 100);
            btn.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            btn.Location = new Point(40, 40);
            btn.Click += my_buttonClick;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;

            Controls.Add(btn);
        }

        private void my_buttonClick(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}
