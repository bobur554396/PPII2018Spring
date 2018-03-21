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
            //Image img = Image.FromFile(@"2.jpg");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap origin = new Bitmap(@"2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = origin;

            Bitmap btm2 = new Bitmap(origin.Width, origin.Height);
            Bitmap btm3 = new Bitmap(origin.Width, origin.Height);
            Bitmap btm4 = new Bitmap(origin.Width, origin.Height);
            Bitmap btm5 = new Bitmap(origin.Width, origin.Height);

            for (int i = 0; i < origin.Width; i++)
            {
                for (int j = 0; j < origin.Height; j++)
                {
                    Color pix = origin.GetPixel(i, j);

                    Color myRed = Color.FromArgb(pix.R, 0, 0);
                    Color myGreen = Color.FromArgb(0, pix.G, 0);
                    Color myBlue = Color.FromArgb(0, 0, pix.B);

                    int avg = (pix.R + pix.G + pix.B) / 3;

                    Color grey = Color.FromArgb(avg, avg, avg);
                    
                    btm2.SetPixel(i, j, myRed);
                    btm3.SetPixel(i, j, myGreen);
                    btm4.SetPixel(i, j, myBlue);

                    btm5.SetPixel(i, j, grey);
                }
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = btm2;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = btm3;

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = btm4;

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = btm5;

        }
    }
}
