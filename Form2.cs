using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Imagenes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Image qr, string codigo)
        {
            InitializeComponent();
            pictureBox1.Image = Cargada(codigo,qr);
        }
        bool cargar = false;
        public bool OKButtonClicked
        {
            get { return cargar; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public Image Cargada(string code, Image qr)
        {

            string[] codigo = code.Split(',');
            int s = int.Parse(codigo[2]);
            string[] array = new string[s * s];
            for (int i = 0; i < s * s; i++)
            {
                array[i] = codigo[Array.IndexOf(codigo, "a-") + 1 + i];
            }
            Bitmap imagen = new Bitmap(600, 450);
            Graphics grafico = Graphics.FromImage(imagen);
            grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            int temper = 0;
            int sq = 300 / s, x = 0, y = 0;
            Color valuecolor = Color.White;
            grafico.DrawLine(new Pen(Color.Black, 5), 45, 45, sq * s + 45, 45);
            grafico.DrawLine(new Pen(Color.Black, 5), 45, 45, 45, sq * s + 45);
            grafico.DrawLine(new Pen(Color.Black, 5), sq * s + 45, 45, sq * s + 45, sq * s + 45);
            grafico.DrawLine(new Pen(Color.Black, 5), 45, sq * s + 45, sq * s + 45, sq * s + 45);
            for (int i = 0; i < s; i++)
            {
                y = i * sq + 50;
                for (int ii = 0; ii < s; ii++)
                {
                    x = ii * sq + 50;
                    valuecolor = ColorTranslator.FromHtml(array[temper]);
                    grafico.FillRectangle(new SolidBrush(valuecolor), x, y, sq, sq);
                    grafico.DrawRectangle(new Pen(valuecolor), x, y, sq, sq);
                    temper++;
                }
            }
            grafico.DrawImage(qr, 400, 50, 150, 150);
            grafico.DrawString("Dimension :", new Font("Arial", 16), new SolidBrush(Color.DarkGray), 370, 250);
            grafico.DrawString(s + " x " + s, new Font("Arial", 16), new SolidBrush(Color.Black), 370, 270);
            grafico.DrawString("Hecho por :", new Font("Arial", 16), new SolidBrush(Color.DarkGray), 370, 290);
            grafico.DrawString(codigo[1], new Font("Arial", 16), new SolidBrush(Color.Black), 370, 310);
            return imagen;
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Guardar imagen";
            sf.Filter = "Bitmap|*.bmp|JPEG |*.jpeg|PNG |*.png";
            sf.FilterIndex = 1;
            sf.FileName = "ElDibujo";
            if (sf.FileName != "" && sf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)sf.OpenFile();
                switch (sf.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }

        private void buttoncargar_Click(object sender, EventArgs e)
        {
            cargar = true;
            this.Close();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            cargar = false;
            this.Close();
        }
    }
}
