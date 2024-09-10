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
        public vistaPrincipal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArticulo formNuevoArticulo = new NuevoArticulo();

            formNuevoArticulo.Show();

            
        }

        private void vistaPrincipal_Load(object sender, EventArgs e)
        {
            ServiceDB serviceDB = new ServiceDB();
            dgvArticulos.DataSource = serviceDB.listar();

        }
    }
}
