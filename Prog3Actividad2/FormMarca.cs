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
    public partial class FormMarca : Form
    {
        private Marca marcaExistente;
        private bool esModificacion;

        public FormMarca()
        {
            InitializeComponent();
        }
        public FormMarca(Marca marca)
        {
            InitializeComponent();
            esModificacion = true;
            this.marcaExistente = marca;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marcaExistente != null && esModificacion)
                {
                    inputDescripcion.Text = marcaExistente.Descripcion;
                    this.Text = "Modificar Marca";
                }
                else
                {
                    this.Text = "Nueva Marca";
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
            Marca marca = new Marca();
            ServiceDB service = new ServiceDB();
            try
            {
                if (validarForm()) return;
                marca.Descripcion = inputDescripcion.Text;
                
                if (esModificacion) {
                    marca.Id = marcaExistente.Id;
                    service.Modificar(marca);
                } else
                {
                    service.Agregar(marca);
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
