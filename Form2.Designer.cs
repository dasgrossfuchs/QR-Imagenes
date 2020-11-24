
namespace QR_Imagenes
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttoncargar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QR_Imagenes.Properties.Resources.Mcbck;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttoncargar
            // 
            this.buttoncargar.Location = new System.Drawing.Point(230, 327);
            this.buttoncargar.Name = "buttoncargar";
            this.buttoncargar.Size = new System.Drawing.Size(75, 23);
            this.buttoncargar.TabIndex = 1;
            this.buttoncargar.Text = "Cargar";
            this.buttoncargar.UseVisualStyleBackColor = true;
            this.buttoncargar.Click += new System.EventHandler(this.buttoncargar_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(410, 326);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(75, 23);
            this.buttoncancelar.TabIndex = 2;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(5, 327);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(151, 23);
            this.buttonguardar.TabIndex = 3;
            this.buttonguardar.Text = "Guardar Imagen";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 351);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttoncargar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttoncargar;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button buttonguardar;
    }
}