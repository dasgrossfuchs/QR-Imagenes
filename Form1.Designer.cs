
namespace QR_Imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonayuda = new System.Windows.Forms.Button();
            this.botonsalir = new System.Windows.Forms.Button();
            this.botoncargar = new System.Windows.Forms.Button();
            this.botonguardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonguardarimagen = new System.Windows.Forms.Button();
            this.dimension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botoncolor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonayuda
            // 
            this.botonayuda.Location = new System.Drawing.Point(368, 282);
            this.botonayuda.Name = "botonayuda";
            this.botonayuda.Size = new System.Drawing.Size(75, 23);
            this.botonayuda.TabIndex = 0;
            this.botonayuda.Text = "Ayuda";
            this.botonayuda.UseVisualStyleBackColor = true;
            // 
            // botonsalir
            // 
            this.botonsalir.Location = new System.Drawing.Point(504, 299);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(75, 23);
            this.botonsalir.TabIndex = 1;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = true;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // botoncargar
            // 
            this.botoncargar.Location = new System.Drawing.Point(488, 220);
            this.botoncargar.Name = "botoncargar";
            this.botoncargar.Size = new System.Drawing.Size(101, 23);
            this.botoncargar.TabIndex = 2;
            this.botoncargar.Text = "Abrir codigo";
            this.botoncargar.UseVisualStyleBackColor = true;
            this.botoncargar.Click += new System.EventHandler(this.botoncargar_Click);
            // 
            // botonguardar
            // 
            this.botonguardar.Location = new System.Drawing.Point(488, 162);
            this.botonguardar.Name = "botonguardar";
            this.botonguardar.Size = new System.Drawing.Size(101, 23);
            this.botonguardar.TabIndex = 3;
            this.botonguardar.Text = "Guardar codigo";
            this.botonguardar.UseVisualStyleBackColor = true;
            this.botonguardar.Click += new System.EventHandler(this.botonguardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botonguardarimagen
            // 
            this.botonguardarimagen.Location = new System.Drawing.Point(488, 191);
            this.botonguardarimagen.Name = "botonguardarimagen";
            this.botonguardarimagen.Size = new System.Drawing.Size(101, 23);
            this.botonguardarimagen.TabIndex = 7;
            this.botonguardarimagen.Text = "Guardar imagen";
            this.botonguardarimagen.UseVisualStyleBackColor = true;
            this.botonguardarimagen.Click += new System.EventHandler(this.botonguardarimagen_Click);
            // 
            // dimension
            // 
            this.dimension.BackColor = System.Drawing.SystemColors.Control;
            this.dimension.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dimension.FormattingEnabled = true;
            this.dimension.Items.AddRange(new object[] {
            "1 x 1",
            "2 x 2",
            "3 x 3",
            "4 x 4",
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8",
            "9 x 9",
            "10 x 10",
            "11 x 11",
            "12 x 12",
            "13 x 13",
            "14 x 14",
            "15 x 15",
            "16 x 16"});
            this.dimension.Location = new System.Drawing.Point(331, 75);
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(112, 21);
            this.dimension.TabIndex = 8;
            this.dimension.SelectedIndexChanged += new System.EventHandler(this.dimension_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dimensiones";
            // 
            // botoncolor
            // 
            this.botoncolor.BackColor = System.Drawing.Color.White;
            this.botoncolor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botoncolor.Location = new System.Drawing.Point(331, 149);
            this.botoncolor.Name = "botoncolor";
            this.botoncolor.Size = new System.Drawing.Size(112, 36);
            this.botoncolor.TabIndex = 11;
            this.botoncolor.UseVisualStyleBackColor = false;
            this.botoncolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Color seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "#FFFFFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(330, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 233);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botoncolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimension);
            this.Controls.Add(this.botonguardarimagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonguardar);
            this.Controls.Add(this.botoncargar);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.botonayuda);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonayuda;
        private System.Windows.Forms.Button botonsalir;
        private System.Windows.Forms.Button botoncargar;
        private System.Windows.Forms.Button botonguardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonguardarimagen;
        private System.Windows.Forms.ComboBox dimension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botoncolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

