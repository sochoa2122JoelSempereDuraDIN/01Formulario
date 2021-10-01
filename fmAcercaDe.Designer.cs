
namespace Proyecto01
{
    partial class fmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercaDe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laAutor = new System.Windows.Forms.Label();
            this.laProyecto = new System.Windows.Forms.Label();
            this.laVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // laAutor
            // 
            this.laAutor.AutoSize = true;
            this.laAutor.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laAutor.Location = new System.Drawing.Point(294, 53);
            this.laAutor.Name = "laAutor";
            this.laAutor.Size = new System.Drawing.Size(287, 25);
            this.laAutor.TabIndex = 1;
            this.laAutor.Text = "Autor:  Joel Sempere Durá";
            this.laAutor.Click += new System.EventHandler(this.label1_Click);
            // 
            // laProyecto
            // 
            this.laProyecto.AutoSize = true;
            this.laProyecto.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laProyecto.Location = new System.Drawing.Point(294, 112);
            this.laProyecto.Name = "laProyecto";
            this.laProyecto.Size = new System.Drawing.Size(260, 25);
            this.laProyecto.TabIndex = 2;
            this.laProyecto.Text = "Proyecto:  El formulario";
            this.laProyecto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // laVersion
            // 
            this.laVersion.AutoSize = true;
            this.laVersion.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laVersion.Location = new System.Drawing.Point(294, 171);
            this.laVersion.Name = "laVersion";
            this.laVersion.Size = new System.Drawing.Size(119, 25);
            this.laVersion.TabIndex = 3;
            this.laVersion.Text = "Versión:  1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:  Septiembre de 2021";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // laDescripcion
            // 
            this.laDescripcion.AutoSize = true;
            this.laDescripcion.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laDescripcion.Location = new System.Drawing.Point(77, 316);
            this.laDescripcion.Name = "laDescripcion";
            this.laDescripcion.Size = new System.Drawing.Size(650, 50);
            this.laDescripcion.TabIndex = 5;
            this.laDescripcion.Text = "Proyecto para practicar distintos controles, como botones y label\r\nen el formular" +
    "io. Sus propiedades y eventos.";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(690, 399);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // fmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.laDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laVersion);
            this.Controls.Add(this.laProyecto);
            this.Controls.Add(this.laAutor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laAutor;
        private System.Windows.Forms.Label laProyecto;
        private System.Windows.Forms.Label laVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laDescripcion;
        private System.Windows.Forms.Button btnAceptar;
    }
}