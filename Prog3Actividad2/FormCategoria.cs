using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo12b
{
    public partial class FormCategoria : Form
    {
        private Categoria categoriaExistente;
        private bool esModificacion;
        public FormCategoria()
        {
            InitializeComponent();
        }

        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            esModificacion = true;
            this.categoriaExistente = categoria;
        }


        private void FormCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoriaExistente != null && esModificacion)
                {
                    inputDescripcion.Text = categoriaExistente.Descripcion;
                    this.Text = "Modificar Categoría";
                }
                else
                {
                    this.Text = "Nueva Categoría";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private bool validarForm()
        {
            if (string.IsNullOrWhiteSpace(inputDescripcion?.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción.");
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(); 
            ServiceDB service = new ServiceDB();
            try
            {
                if (validarForm()) return;
                categoria.Descripcion = inputDescripcion.Text;
                
                if (esModificacion) {
                    categoria.Id = categoriaExistente.Id;
                    service.Modificar(categoria);
                } else
                {
                    service.Agregar(categoria);
                }

                if (esModificacion) {
                    MessageBox.Show("Modificada exitosamente");
                } else
                {
                    MessageBox.Show("Agregada exitosamente");
                }

                this.DialogResult = DialogResult.OK;
                Close();

            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }
    }
}
