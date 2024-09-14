using Dominio;

namespace Prog3Actividad2
{
    partial class NuevoArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.inputImagenUrl = new System.Windows.Forms.TextBox();
            this.imagenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imagen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // inputCodigo
            // 
            this.inputCodigo.Location = new System.Drawing.Point(153, 61);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(155, 20);
            this.inputCodigo.TabIndex = 0;
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(153, 93);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(155, 20);
            this.inputNombre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(153, 125);
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(155, 20);
            this.inputDescripcion.TabIndex = 2;
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(153, 254);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(155, 20);
            this.inputPrecio.TabIndex = 6;
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(153, 158);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(155, 21);
            this.comboMarca.TabIndex = 3;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(153, 190);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(155, 21);
            this.comboCategoria.TabIndex = 4;
            // 
            // inputImagenUrl
            // 
            this.inputImagenUrl.Location = new System.Drawing.Point(153, 222);
            this.inputImagenUrl.Name = "inputImagenUrl";
            this.inputImagenUrl.Size = new System.Drawing.Size(155, 20);
            this.inputImagenUrl.TabIndex = 5;
            this.inputImagenUrl.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // imagenBox
            // 
            this.imagenBox.Location = new System.Drawing.Point(367, 46);
            this.imagenBox.Name = "imagenBox";
            this.imagenBox.Size = new System.Drawing.Size(262, 241);
            this.imagenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenBox.TabIndex = 9;
            this.imagenBox.TabStop = false;
            // 
            // NuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.imagenBox);
            this.Controls.Add(this.inputImagenUrl);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.inputPrecio);
            this.Controls.Add(this.inputDescripcion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.inputCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "NuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.NuevoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox inputImagenUrl;
        private System.Windows.Forms.PictureBox imagenBox;
    }
}

