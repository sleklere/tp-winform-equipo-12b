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
            inputCampo.Items.Add("Id");
            inputCampo.Items.Add("Nombre");
            inputCampo.Items.Add("Marca");
            inputCampo.Items.Add("Categoria");
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

        private void verTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();
            formCategoria.ShowDialog();
        }

        private void inputCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = inputCampo.SelectedItem.ToString();
            if (opcion == "Id")
            {
                inputCriterio.Items.Clear();
                inputCriterio.Items.Add("Mayor a");
                inputCriterio.Items.Add("Menor a");
                inputCriterio.Items.Add("Igual a");
            }
            else
            {
                inputCriterio.Items.Clear();
                inputCriterio.Items.Add("Comienza con");
                inputCriterio.Items.Add("Termina con");
                inputCriterio.Items.Add("Contiene");
            }

        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool validarFiltro()
        {
            if (inputCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (inputCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (inputCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(inputFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(inputFiltro.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            ServiceDB service = new ServiceDB();
            try
            {
                if (validarFiltro())
                    return;

                string campo = inputCampo.SelectedItem.ToString();
                string criterio = inputCriterio.SelectedItem.ToString();
                string filtro = inputFiltro.Text;
                dgvArticulos.DataSource = service.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
