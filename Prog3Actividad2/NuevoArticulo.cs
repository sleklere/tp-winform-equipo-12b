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
using static System.Net.WebRequestMethods;

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
            Imagen img = new Imagen();

            try
            {
                art.Codigo = inputCodigo.Text;
                art.Nombre = inputNombre.Text;
                art.Descripcion = inputDescripcion.Text;
                art.Marca = (Marca)comboMarca.SelectedItem;
                art.Categoria = (Categoria)comboCategoria.SelectedItem;
                art.Precio = decimal.Parse(inputPrecio.Text);

                service.Agregar(art);

                int artId = service.GetArticuloIdByCod(inputCodigo.Text);
                if (artId != -1)
                {
                    img.IdArticulo = (int)artId;
                    if (inputImagenUrl != null && inputImagenUrl.Text.ToUpper().Contains("HTTP"))
                    {
                        img.ImagenUrl = inputImagenUrl.Text;
                    } else
                    {
                        img.ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx4xrkRCeiKCPwkflbkXd11W_2fzx34RemdWXmv8TXYWLT2SGtLfkqFCyBb_CBoNcNVBc&usqp=CAU";
                    }
                    service.AgregarImagen(img);
                }

                MessageBox.Show("Agregado exitosamente");

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
        private void textBox1_Leave(object sender, EventArgs e)
        {
            cargarImagen(inputImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                imagenBox.Load(imagen);
            }
            catch (Exception ex)
            {
                imagenBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx4xrkRCeiKCPwkflbkXd11W_2fzx34RemdWXmv8TXYWLT2SGtLfkqFCyBb_CBoNcNVBc&usqp=CAU");
            }
        }


    }
}
