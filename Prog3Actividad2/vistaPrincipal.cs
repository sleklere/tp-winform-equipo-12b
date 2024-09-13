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

namespace Prog3Actividad2
{
    public partial class vistaPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public vistaPrincipal()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ServiceDB service = new ServiceDB();
            try
            {
                listaArticulos = service.listar();
                dgvArticulos.DataSource = listaArticulos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArticulo formNuevoArticulo = new NuevoArticulo();
            formNuevoArticulo.ShowDialog();
            Cargar();
        }

        private void vistaPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServiceDB service = new ServiceDB();
            Articulo art;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    service.Eliminar(art.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Detalle detalleArticulo = new Detalle();
            detalleArticulo.ShowDialog();
            //Cargar();
        }
    }
}
