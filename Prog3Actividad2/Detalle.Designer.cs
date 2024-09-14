namespace Prog3Actividad2
{
    partial class Detalle
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
            this.imagenBox = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenBox
            // 
            this.imagenBox.Location = new System.Drawing.Point(354, 33);
            this.imagenBox.Name = "imagenBox";
            this.imagenBox.Size = new System.Drawing.Size(262, 241);
            this.imagenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenBox.TabIndex = 26;
            this.imagenBox.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(371, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(215, 305);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(199, 70);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(10, 13);
            this.codigo.TabIndex = 27;
            this.codigo.Text = "-";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(199, 102);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(10, 13);
            this.nombre.TabIndex = 28;
            this.nombre.Text = "-";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(199, 135);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(10, 13);
            this.descripcion.TabIndex = 29;
            this.descripcion.Text = "-";
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(199, 167);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(10, 13);
            this.marca.TabIndex = 30;
            this.marca.Text = "-";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Location = new System.Drawing.Point(199, 199);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(10, 13);
            this.categoria.TabIndex = 31;
            this.categoria.Text = "-";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(199, 229);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(16, 13);
            this.precio.TabIndex = 33;
            this.precio.Text = "$-";
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.imagenBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.imagenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenBox;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label precio;
    }
}