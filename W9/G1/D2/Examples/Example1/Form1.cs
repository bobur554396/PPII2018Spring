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
        Button btn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create button 
            btn = new Button();
            btn.Size = new Size(100, 100);
            btn.Location = new Point(100, 100);
            btn.BackColor = Color.Blue;
            //btn.ForeColor = Color.White;
            //btn.Text = "Button";
            btn.Click += button_click;

            // create label
            Label l = new Label();
            l.Text = "some text";
            l.Location = new Point(30, 30);


            // create text input
            TextBox input = new TextBox();
            input.Location = new Point(200, 30);


            Controls.Add(input);
            Controls.Add(l);
            Controls.Add(btn);
            //button1.BackColor = Color.Blue;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            btn1.BackColor = Color.Red;
            //btn.BackColor = Color.Red;
        }
    }
}
