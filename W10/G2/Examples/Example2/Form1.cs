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
            BackColor = Color.Green;
            timer1.Interval = 100;
            timer1.Start();
        }
        int cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                BackColor = Color.Green;
                cnt++;
            }
            else if(cnt == 1)
            {
                BackColor = Color.Red;
                cnt = 0;
            }

        }
    }
}
