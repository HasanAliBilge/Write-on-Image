using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string image;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            image= openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(image);
        }
        Color color;
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
          color= colorDialog1.Color;
        }
        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
             bmp = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawString(textBox1.Text,new Font("UNISPACE",Convert.ToInt32(textBox2.Text),FontStyle.Bold),new SolidBrush(color),20,30);
            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp";
            saveFileDialog1.FileName = "edited_image.jpg";
            saveFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
