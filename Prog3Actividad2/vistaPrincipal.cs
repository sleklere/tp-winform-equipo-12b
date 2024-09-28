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
                listaArticulos = service.listarArticulos();
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

        //private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    NuevoArticulo formNuevoArticulo = new NuevoArticulo();
        //    formNuevoArticulo.ShowDialog();
        //    Cargar();
        //}

        private void vistaPrincipal_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo art;
            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Detalle detalleArticulo = new Detalle(art);
            detalleArticulo.ShowDialog();
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoArticulo formNuevoArticulo = new NuevoArticulo();
            formNuevoArticulo.ShowDialog();
            Cargar();
        }


        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca(); 
            formMarca.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArticulo formNuevoArticulo = new NuevoArticulo();
            formNuevoArticulo.ShowDialog();
            Cargar();

        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.ShowDialog();
        }
    }
}
