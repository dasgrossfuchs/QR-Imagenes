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
    public partial class Form1 : Form
    {
        int size;
        string name;
        string cadena;
        string[,] pixel;
        Color color;
        PictureBox[,] pxl;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dimension.SelectedIndex = 15;
            cuadricular();
            color = ColorTranslator.FromHtml("#000000");
            //Color c = new Color();
            //c = ColorTranslator.FromHtml("#00000000") ;
        }
        public void cuadricular()
        {
            size = dimension.SelectedIndex + 1;
            pixel = new string[size, size];
            pxl = new PictureBox[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int ii = 0; ii < size; ii++)
                {
                    pixel[i, ii] = "t";
                }
            }
            int w = panel1.Width / size;
            int h = panel1.Height / size;

            for (int i = 0; i < size; i++)
            {
                for (int ii = 0; ii < size; ii++)
                {
                    int x = panel1.Location.X + (w * ii);
                    int y = panel1.Location.Y + (h * i);
                    pxl[i,ii] = new PictureBox();
                    pxl[i, ii].Size = new Size(w, h);
                    pxl[i, ii].Location = new Point(x, y);
                    pxl[i, ii].Name = "lbl" + (ii + i * 10);
                    pxl[i, ii].BorderStyle = BorderStyle.FixedSingle;
                    pxl[i, ii].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(pxl[i,ii]);
                }
            }
            panel1.SendToBack();
            actualizardibujo();
        }
        public Image img(string value)
        {
            Bitmap imagen = new Bitmap(16,16);
            Graphics grafico = Graphics.FromImage(imagen);
            grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            if (value == "t")
            {
                grafico.FillRectangle(new SolidBrush(Color.Gray), 0, 0, 8, 8);
                grafico.FillRectangle(new SolidBrush(Color.Gray), 8, 8, 8, 8);
                grafico.FillRectangle(new SolidBrush(Color.White), 8, 0, 8, 8);
                grafico.FillRectangle(new SolidBrush(Color.White), 0, 8, 8, 8);

            }
            else
            {
                grafico.FillRectangle(new SolidBrush(color), 0, 0, 15, 15);
                grafico.DrawRectangle(new Pen(color), 0, 0, 15, 15);
            }
            return imagen;
        }
        public void actualizardibujo()
        {
            for (int i = 0; i < size; i++)
            {
                for (int ii = 0; ii < size; ii++)
                {
                    pxl[i, ii].Image = img(pixel[i,ii]);
                    pxl[i, ii].Refresh();
                }
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int ii = 0; ii < 10; ii++)
            //    {
            //        string name = "lbl" + (ii + i * 10);

            //        Control ctn = this.Controls[name];

            //        ctn.Text = procesos[(ii + i * 10)].ToString();
            //    }
            //}
        }
        //Botones Inicio
        private void botonsalir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);  
        }

        //Botones Fin
        //Analizadores Inicio
        //Lexico
        /*Explicacion Lexer
         * Estructura base del codigo:
         * 
         * qrimg,nombre_autor<string>,ancho_imagen<int>,a-,arreglo_pixeles,-o
         * 
         * ----El nombre del autor sera parte de la informacion
         * ----Dado que la imagen generada por el momento sera cuadrada solo se necesita el ancho.
         * ----El inicio del arreglo es marcado por "a-" y el final por "-o"
         * 
         * Estructura del arreglo de pixeles:
         * 
         *      a-,'00','01','02',...,'0n','10',...,'1n',...,'n0',...,'nn',-o
         *      
         * ----cada pixel separado por una coma y contenido dentro de comillas sencillas
         * ----cada pixel contiene 6 caracteres en el formato '#000000'
         * ----la transparencia es simbolizada por 't'
         */
        public void Lexico(string code)
        {
            string[] arreglo = code.Split(',');
            string error = "formato";
            int tempsize;
            try
            {
                if (arreglo[0] != "qrimg")
                {
                    error = "El codigo no esta validado para continuar.";
                    throw new FormatException();
                }
                tempsize = Int32.Parse(arreglo[2]);
                if (Array.IndexOf(arreglo,"a-") != 3 || Array.IndexOf(arreglo, "-o") != (4 + tempsize*tempsize))
                {
                    error = "Faltan limitantes de arreglo de pixeles.";
                    throw new FormatException();
                }
                for (int i = 0; i < tempsize*tempsize; i++)
                {
                    if (arreglo[4+i].Length != 9 && arreglo[4+i] != "'t'" )
                    {
                        error = "El color del pixel en la posicion "+(4+i)+" no esta en el formato esperado\n" +
                            "color = "+arreglo[4+i]+".\nSe esperaba '#000000' o 't'";
                        throw new FormatException();
                    }
                }
            }
            catch (FormatException e)
            {MessageBox.Show("El codigo no esta en el formato esperado \ndetalle:\n"+error, "Error");return;}
            catch (Exception e)
            {MessageBox.Show(e.Message, "Error");return;}
        }
        //Lexico
        //Sintactico
        //Sintactico
        //Semantico
        //Semantico
        //Analizadores Fin

    }
}
