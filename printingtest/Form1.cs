using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printingtest
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                //  printPreviewDialog1.ShowDialog();
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1 .Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawImage(BMP, 0, 0);
           
        }
        Bitmap BMP;
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics G = this .CreateGraphics();

            BMP = new Bitmap(this.Size.Width, this.Size .Height, G);
            Graphics mg = Graphics.FromImage(BMP);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintPreviewControl abc = new PrintPreviewControl();
            

        }
    }
}
