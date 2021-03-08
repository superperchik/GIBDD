using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace spectr
{
    public partial class Form1 : Form
    {
        Bitmap bitmp; 
        Point p;
        public Form1()
        {
            InitializeComponent();
            bitmp = new Bitmap(pictureBox1.Image,pictureBox1.Width,pictureBox1.Height);
        }


        private void pictureBox1_PreviewMouseDown(object sender, MouseEventArgs e)
        {
            
            p = pictureBox1.PointToClient(Cursor.Position);
            textBox1.Text = ColorTranslator.ToHtml(bitmp.GetPixel(p.X, p.Y)).ToString();
           panel1.BackColor = ColorTranslator.FromHtml(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
