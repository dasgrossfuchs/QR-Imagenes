
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
            this.botonayuda = new System.Windows.Forms.Button();
            this.botonsalir = new System.Windows.Forms.Button();
            this.botoncargar = new System.Windows.Forms.Button();
            this.botonguardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonguardarimagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonayuda
            // 
            this.botonayuda.Location = new System.Drawing.Point(713, 12);
            this.botonayuda.Name = "botonayuda";
            this.botonayuda.Size = new System.Drawing.Size(75, 23);
            this.botonayuda.TabIndex = 0;
            this.botonayuda.Text = "Ayuda";
            this.botonayuda.UseVisualStyleBackColor = true;
            // 
            // botonsalir
            // 
            this.botonsalir.Location = new System.Drawing.Point(713, 415);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(75, 23);
            this.botonsalir.TabIndex = 1;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = true;
            // 
            // botoncargar
            // 
            this.botoncargar.Location = new System.Drawing.Point(687, 386);
            this.botoncargar.Name = "botoncargar";
            this.botoncargar.Size = new System.Drawing.Size(101, 23);
            this.botoncargar.TabIndex = 2;
            this.botoncargar.Text = "Abrir codigo";
            this.botoncargar.UseVisualStyleBackColor = true;
            // 
            // botonguardar
            // 
            this.botonguardar.Location = new System.Drawing.Point(645, 236);
            this.botonguardar.Name = "botonguardar";
            this.botonguardar.Size = new System.Drawing.Size(101, 23);
            this.botonguardar.TabIndex = 3;
            this.botonguardar.Text = "Guardar codigo";
            this.botonguardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(617, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botonguardarimagen
            // 
            this.botonguardarimagen.Location = new System.Drawing.Point(221, 327);
            this.botonguardarimagen.Name = "botonguardarimagen";
            this.botonguardarimagen.Size = new System.Drawing.Size(101, 23);
            this.botonguardarimagen.TabIndex = 7;
            this.botonguardarimagen.Text = "Guardar imagen";
            this.botonguardarimagen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonguardarimagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonguardar);
            this.Controls.Add(this.botoncargar);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.botonayuda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonayuda;
        private System.Windows.Forms.Button botonsalir;
        private System.Windows.Forms.Button botoncargar;
        private System.Windows.Forms.Button botonguardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonguardarimagen;
    }
}

