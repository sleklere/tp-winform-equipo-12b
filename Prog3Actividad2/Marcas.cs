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
    public partial class Marcas : Form
    {
        private List<Marca> listaMarcas;
        public Marcas()
        {
            InitializeComponent();
        }
        
        private void Cargar()
        {
            ServiceDB service = new ServiceDB();
            try
            {
                listaMarcas = service.listarMarcas();
                dgvMarcas.DataSource = listaMarcas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Marcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca(); 
            formMarca.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca marca;
            marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            ServiceDB service = new ServiceDB();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminar la marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    service.EliminarMarca(marca.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ServiceDB service = new ServiceDB();
            Marca marca;
            marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            FormMarca formMarca = new FormMarca(marca);
            formMarca.ShowDialog();
            Cargar();

        }
    }
}
