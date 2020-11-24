using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorPickerWPF;
using QRCodeEncoderLibrary;
using QRCodeDecoderLibrary;


namespace QR_Imagenes
{
    public partial class Form1 : Form
    {
        int size = 0;
        string cadena;
        string[] pixel;
        string selcol = "#FFFFFF";
        PictureBox[] pxl;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dimension.SelectedIndex = 15;
            textBox1.Text = "anon";
            //color = ColorTranslator.FromHtml("#FFFFFF");
            //color = Color.Black;
            ////Color c = new Color();
            ////c = ColorTranslator.FromHtml("#00000000") ;
            //label2.Text = "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            //label3.Text = label2.Text.Replace("#","");
            //label4.Text = int.Parse(label2.Text.Replace("#", ""),System.Globalization.NumberStyles.HexNumber).ToString();
            
        }
        
        //Dibujo
        public void cuadricular()
        {
            size = dimension.SelectedIndex + 1;
            pixel = new string[size*size];
            pxl = new PictureBox[size*size];
            for (int i = 0; i < size*size; i++)
            {
                pixel[i] = "t";
            }
            int w = panel1.Width / size;
            int cont=0;
            for (int i = 0; i < size; i++)
            {
                for (int ii = 0; ii < size; ii++)
                {

                    int x = panel1.Location.X + (w * ii);
                    int y = panel1.Location.Y + (w * i);
                    pxl[cont] = new PictureBox();
                    pxl[cont].Size = new Size(w,w);
                    pxl[cont].Location = new Point(x, y);
                    pxl[cont].Name = "lbl" + (cont);
                    pxl[cont].BorderStyle = BorderStyle.FixedSingle;
                    pxl[cont].SizeMode = PictureBoxSizeMode.StretchImage;
                    pxl[cont].MouseClick += clickcuadro;
                    this.Controls.Add(pxl[cont]);
                    cont++;
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
                Color valuecolor = ColorTranslator.FromHtml(value); 
                grafico.FillRectangle(new SolidBrush(valuecolor), 0, 0, 15, 15);
                grafico.DrawRectangle(new Pen(valuecolor), 0, 0, 15, 15);
            }
            return imagen;
        }
        public Image Completa(string[] array)
        {
            Bitmap imagen = new Bitmap(size*panel1.Width,size*panel1.Width);
            Graphics grafico = Graphics.FromImage(imagen);
            grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            int temper = 0;
            int sq = panel1.Width/size,x=0,y=0;
            Color valuecolor = Color.White;
            for (int i = 0; i < size; i++)
            {
                y = i * sq;
                for (int ii = 0; ii < size; ii++)
                {
                    x = ii * sq;
                    if (array[temper] != "t")
                    {
                        valuecolor = ColorTranslator.FromHtml(array[temper]);
                    }
                    else { valuecolor = ColorTranslator.FromHtml("#FFFFFF");}
                    grafico.FillRectangle(new SolidBrush(valuecolor), x, y, sq, sq);
                    grafico.DrawRectangle(new Pen(valuecolor), x, y, sq, sq);
                    temper++;
                }
            }
            return imagen;
        }
        public Image Cargada(string code, Image qr)
        {

            string[] codigo = code.Split(',');
            int s = int.Parse(codigo[2]);
            string[] array = new string[s * s];
            for (int i = 0; i < s*s; i++)
            {
                array[i] = codigo[Array.IndexOf(codigo, "a-") + 1 + i];
            }
            Bitmap imagen = new Bitmap(600, 450);
            Graphics grafico = Graphics.FromImage(imagen);
            grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            int temper = 0;
            int sq = 300/size, x = 0, y = 0;
            Color valuecolor = Color.White;
            grafico.DrawLine(new Pen(Color.Black,5), 45, 45, sq * s + 45, 45);
            grafico.DrawLine(new Pen(Color.Black, 5), 45, 45, 45,sq * s + 45);
            grafico.DrawLine(new Pen(Color.Black, 5), sq * s + 45, 45,sq * s + 45, sq * s + 45);
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
            grafico.DrawString(s+" x "+s, new Font("Arial", 16), new SolidBrush(Color.Black), 370, 270);
            grafico.DrawString("Hecho por :", new Font("Arial", 16), new SolidBrush(Color.DarkGray), 370, 290);
            grafico.DrawString(codigo[1], new Font("Arial", 16), new SolidBrush(Color.Black), 370, 310);
            return imagen;
        }
        //Actualizaciones
        public void actualizardibujo()
        {
            for (int i = 0; i < size*size; i++)
            {
                pxl[i].Image = img(pixel[i]);
                pxl[i].Refresh();
            }
            actualizarcadena();
        }
        public void actualizarcadena()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "anon";
            }
            cadena = "qrimg," + textBox1.Text + "," + size + ",a-";
            for (int i = 0; i < size*size; i++)
            {
                if (pixel[i] == "t")
                {
                    cadena = cadena + ",#FFFFFF";
                }
                else
                {
                    cadena = cadena + "," +pixel[i];
                }
            }
            cadena = cadena + ",-o";
            actualizarqr();
        }
        public void actualizarqr() 
        {
            QRCodeEncoder qce = new QRCodeEncoder();
            qce.ErrorCorrection = QRCodeEncoderLibrary.ErrorCorrection.L;
            qce.ModuleSize = 4;
            qce.QuietZone = 16;
            qce.Encode(cadena);
            pictureBox1.Image = qce.CreateQRCodeBitmap();
        }
        //Botones eventos
        private void dimension_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (size == 0)
            {cuadricular();return;}
            if (dimension.SelectedIndex == size -1)
            {return;}
            DialogResult dr = MessageBox.Show("La accion reestablecera la imagen, por lo que sera borrada, deseas continuar?", "Redimensionar?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    for (int i = 0; i < size*size; i++)
                    {
                        pxl[i].Dispose();
                    }
                }
                catch (Exception)
                {
                }
                cuadricular();
            }
            else { dimension.SelectedIndex = size - 1; }
        }
        private void botonsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los cambios no seran guardados, esta seguro que desea salir?","Salir?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
        private void botonguardarimagen_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Guardar imagen";
            sf.Filter = "Bitmap|*.bmp|JPEG |*.jpeg|PNG |*.png";
            sf.FilterIndex = 1;
            sf.FileName = "ElDibujoDe"+textBox1.Text;
            if (sf.FileName != "" && sf.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)sf.OpenFile();
                switch (sf.FilterIndex)
                {
                    case 1:
                        this.Completa(pixel).Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        this.Completa(pixel).Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        this.Completa(pixel).Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
            
        }
        private void botoncargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            QRDecoder qd = new QRDecoder();
            of.Title = "Abre el codigo QR";
            of.Filter = "PNG | *.png|JPEG | *.jpeg";
            of.RestoreDirectory= true;
            string codigo = "";
            Image img;
            if (of.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(of.FileName);
                byte[][] DataByteArray = qd.ImageDecoder(new Bitmap(of.FileName));
                codigo = QRDecoder.ByteArrayToStr(DataByteArray[0]);
                Analisis analisis = new Analisis(codigo);
                if (analisis.Error != 0)
                {
                   Errorentrada(analisis.Error);
                }
                else
                {
                    Form2 form2 = new Form2(img,codigo);
                    form2.StartPosition = this.StartPosition;
                    form2.ShowDialog();
                    if (form2.OKButtonClicked)
                    {
                        dimension.SelectedIndex = int.Parse(codigo.Split(',').ElementAt(2)) - 1;
                        if (size == int.Parse(codigo.Split(',').ElementAt(2)))
                        {
                            textBox1.Text = codigo.Split(',').ElementAt(1);
                            for (int i = 0; i < size*size; i++)
                            {
                                pixel[i] = codigo.Split(',').ElementAt(4+i);
                            }
                            actualizardibujo();
                        }
                    }
                    
                    
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Media.Color diacol;
            bool x = ColorPickerWindow.ShowDialog(out diacol,ColorPickerWPF.Code.ColorPickerDialogOptions.SimpleView);
            selcol = diacol.ToString().Remove(1,2);
            botoncolor.BackColor = ColorTranslator.FromHtml(selcol);
            label3.Text = selcol;
        }
        private void clickcuadro(object sender, EventArgs e)
        {
            string n = ((PictureBox)sender).Name;
            for (int i = 0; i < size * size; i++)
            {
                if (pxl[i].Name == n )
                {
                    pixel[i] = selcol;
                    actualizardibujo();
                    return;

                }
                //pixel[i, ii] = selcol;
                //actualizardibujo();
                //return;
            }
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void botonguardar_Click(object sender, EventArgs e)
        {
            actualizarcadena();
            QRCodeEncoder qce = new QRCodeEncoder();
            qce.ErrorCorrection = QRCodeEncoderLibrary.ErrorCorrection.L;
            qce.ModuleSize = 4;
            qce.QuietZone = 16;
            qce.Encode(cadena);

            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Guardar imagen";
            sf.Filter = "PNG |*.png| JPEG |*.jpeg";
            sf.FileName = "Codigo" + textBox1.Text;
            Image qrcode = qce.CreateQRCodeBitmap();
            if (sf.FileName != "" && sf.ShowDialog() == DialogResult.OK)
            {
                
                System.IO.FileStream fs = (System.IO.FileStream)sf.OpenFile();
                switch (sf.FilterIndex)
                {
                    case 1:
                        qrcode.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 2:
                        qrcode.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        qrcode.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }

        }
        //errores
        /*Glosario de errores de entrada
         *  -1 Error sintactico
         *      El codigo ingresado no tiene la estructura 
         *      correcta, por lo que no puede ser procesado.
         *  -2 Error Semantico
         *      El codigo no tiene congruencia entre sus
         *      componentes.
         *  -3 Error lexico
         *      El codigo contiene palabras no reconocidas, codigos de colores ilegales
         *      o no esta en formato hexadecimal.
         *      
         */
        public void Errorentrada(int error)
        {
            switch (error)
            {
                case 1:
                    MessageBox.Show("El codigo no tiene la estructura correcta","Error de Sintaxis");
                    break;
                case 2:
                    MessageBox.Show("El codigo no tiene congruencia entre componentes", "Error de Semantica");
                    break;
                case 3:
                    MessageBox.Show("Los colores no estan en el formato correcto", "Error Lexico");
                    break;
                case 4:
                    MessageBox.Show("", "Error");
                    break;
                default:
                    break;
            }
        }
    }
}
