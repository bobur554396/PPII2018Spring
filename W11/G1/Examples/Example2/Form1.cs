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
            //Image img = Image.FromFile(@"1.png");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap btm1 = new Bitmap(@"2.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = btm1;

            Bitmap btm2 = new Bitmap(@"2.jpg");
            Bitmap btm3 = new Bitmap(@"2.jpg");
            Bitmap btm4 = new Bitmap(@"2.jpg");
            Bitmap btm5 = new Bitmap(@"2.jpg");

            for (int i = 0; i < btm2.Width; i++)
            {
                for(int j = 0; j < btm2.Height; j++)
                {
                    Color pix = btm2.GetPixel(i, j);
                    Color newGreen = Color.FromArgb(0, pix.G, 0);
                    Color newRed = Color.FromArgb(pix.R, 0, 0);
                    Color newBlue = Color.FromArgb(0, 0, pix.B);

                    int avg = (pix.R + pix.G + pix.B) / 3;
                    Color grey = Color.FromArgb(avg, avg, avg);

                    btm2.SetPixel(i, j, newGreen);
                    btm3.SetPixel(i, j, newRed);
                    btm4.SetPixel(i, j, newBlue);

                    btm5.SetPixel(i, j, grey);
                }
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = btm2;

            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = btm3;

            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = btm4;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = btm5;
        }
    }
}
