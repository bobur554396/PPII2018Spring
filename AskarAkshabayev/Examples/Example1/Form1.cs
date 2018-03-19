using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 500;
            Height = 500;

            my_button_1.Text = "my button";

            Button btn = new Button();
            btn.Text = "Button 2";
            btn.Click += btn_Click;
            btn.Location = new Point(20, 100);
            btn.Size = new System.Drawing.Size(100, 100);
            btn.Font = new System.Drawing.Font(FontFamily.GenericSerif, 20);

            Label l = new Label();
            l.Location = new Point(10, 10);
            l.Text = "new label";

            Controls.Add(l);
            Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 2 clicked");
        }


    }
}
