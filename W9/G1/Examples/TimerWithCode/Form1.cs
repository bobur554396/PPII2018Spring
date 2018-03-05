using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWithCode
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
            // Button 
            Button btn = new Button();
            btn.Text = "Start";
            btn.Size = new Size(200, 100);
            btn.Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
            btn.Location = new Point(50, 10);
            btn.Click += my_button_clicked;

            // DateTime show Label
            l = new Label();
            l.Font = new Font(FontFamily.GenericMonospace, 30, FontStyle.Italic);
            l.Text = "empty";
            l.Location = new Point(50, 200);
            l.Height = 70;
            l.Width = 300;

            //Timer
            t = new Timer();
            t.Interval = 1000;
            t.Tick += timer_tick;

            // Add elements to the window
            Controls.Add(btn);
            Controls.Add(l);
        }

        private void my_button_clicked(object sender, EventArgs e)
        {
            t.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            l.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
