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
        Label l;
        Timer t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button create
            Button btn = new Button();
            btn.Text = "my button";
            btn.Location = new Point(50, 40);
            btn.Font = new Font(FontFamily.GenericMonospace, 20);
            btn.Width = 200;
            btn.Height = 70;
            btn.Click += my_button_click;

            // Label create
            l = new Label();
            l.Text = "my text";
            l.Location = new Point(50, 150);
            l.Font = new Font(FontFamily.GenericSansSerif, 20);
            l.Height = 70;
            l.Width = 300;

            //timer create
            t = new Timer();
            t.Interval = 1000;
            t.Tick += my_timer_tick;
            

            // add elements to the window
            Controls.Add(l);
            Controls.Add(btn);
        }
        int k = 0;
        private void my_button_click(object sender, EventArgs e)
        {
            /*l.Text = k+"";
            k++;*/
            t.Start();
        }

        private void my_timer_tick(object sender, EventArgs e)
        {
            l.Text = DateTime.Now.ToLongTimeString();
            //l.Text = k++.ToString();
        }
    }
}
