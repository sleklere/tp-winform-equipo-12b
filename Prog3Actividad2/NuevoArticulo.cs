using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Dominio;

namespace Prog3Actividad2
{
    public partial class NuevoArticulo : Form
    {
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ServiceDB service = new ServiceDB();

            try
            {
                art.Codigo = inputCodigo.Text;
                art.Nombre = inputNombre.Text;
                art.Descripcion = inputDescripcion.Text;
                art.Marca = (Marca)comboMarca.SelectedItem;
                art.Categoria = (Categoria)comboCategoria.SelectedItem;
                //art.UrlImagen = txtUrlImagen.Text;
                art.Precio = decimal.Parse(inputPrecio.Text);


                service.Agregar(art);
                MessageBox.Show("Agregado exitosamente");
                

                //Guardo imagen si la levantó localmente:
                //if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                //    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NuevoArticulo_Load(object sender, EventArgs e)
        {
            ServiceDB service = new ServiceDB();
            try
            {
                comboMarca.DataSource = service.listarMarcas();
                comboCategoria.DataSource = service.listarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
