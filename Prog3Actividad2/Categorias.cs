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
    public partial class Categorias : Form
    {
        private List<Categoria> listaCategorias;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ServiceDB service = new ServiceDB();
            try
            {
                listaCategorias = service.listarCategorias();
                dgvCategorias.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Categorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria(); 
            formCategoria.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            ServiceDB service = new ServiceDB();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminar la categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    service.EliminarCategoria(categoria.Id);
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
            Categoria categoria;
            categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            FormCategoria formCategoria = new FormCategoria(categoria); 
            formCategoria.ShowDialog();
            Cargar();

        }

        private void Categorias_Load_1(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
