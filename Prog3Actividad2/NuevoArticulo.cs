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
        private Articulo articulo;
        private bool esModificacion;
        public Articulo ArticuloModificado { get; private set; }

        public NuevoArticulo()
        {
            InitializeComponent();
            esModificacion = false;
        }
        public NuevoArticulo(Articulo articuloExistente)
        {
            InitializeComponent();
            esModificacion = true;
            articulo = articuloExistente;
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

                if (esModificacion) {
                    art.Id = articulo.Id;
                    service.Modificar(art);
                } else
                {
                    service.Agregar(art);
                }

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

                if (esModificacion) {
                    MessageBox.Show("Modificado exitosamente");
                } else
                {
                    MessageBox.Show("Agregado exitosamente");
                }

                ArticuloModificado = art;
                this.DialogResult = DialogResult.OK;
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
                comboMarca.DisplayMember = "Descripcion"; 
                comboMarca.ValueMember = "Id";

                comboCategoria.DataSource = service.listarCategorias();
                comboCategoria.DisplayMember = "Descripcion";
                comboCategoria.ValueMember = "Id";


                if (articulo != null && esModificacion)
                {
                    try
                    {
                        imagenBox.Load(service.GetImgByArticuloId(articulo.Id).ImagenUrl);
                    }
                    catch (Exception ex)
                    {
                        imagenBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx4xrkRCeiKCPwkflbkXd11W_2fzx34RemdWXmv8TXYWLT2SGtLfkqFCyBb_CBoNcNVBc&usqp=CAU");
                    }

                    inputCodigo.Text = articulo.Codigo;
                    inputNombre.Text = articulo.Nombre;
                    inputDescripcion.Text = articulo.Descripcion;
                    //inputImagenUrl.Text = articulo.ImagenUrl;
                    inputPrecio.Text = articulo.Precio.ToString();
                    comboMarca.SelectedIndex = comboMarca.FindStringExact(articulo.Marca.ToString());
                    comboCategoria.SelectedIndex = comboCategoria.FindStringExact(articulo.Categoria.ToString());
                    this.Text = "Modificar Artículo";
                }
                else
                {
                    this.Text = "Nuevo Artículo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
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
