using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace stick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 3;
            numericUpDown1.Maximum = 30000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = decimal.ToInt32(numericUpDown1.Value);
            Bitmap bmp = new Bitmap(size, size);
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    bmp.SetPixel(i, i, Color.FromArgb(255, 137, 103, 39));
                }
                else
                {
                    bmp.SetPixel(i, i, Color.FromArgb(255, 104, 78, 30));
                }
                if (i != size - 1)
                {
                    bmp.SetPixel(i + 1, i, Color.FromArgb(255, 40, 30, 11));
                    bmp.SetPixel(i, i + 1, Color.FromArgb(255, 73, 54, 8));
                }
            }
            bmp.SetPixel(0, 0, Color.FromArgb(255, 40, 30, 11));
            bmp.SetPixel(size - 1, size - 1, Color.FromArgb(255, 40, 30, 11));

            bmp.SetPixel(1, 1, Color.FromArgb(255, 137, 103, 39));
            bmp.SetPixel(size - 3, size - 3, Color.FromArgb(255, 137, 103, 39));

            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName, ImageFormat.Png);
        }
    }
}
