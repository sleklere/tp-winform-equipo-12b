﻿using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo12b
{
    public partial class Detalle : Form
    {
        private Articulo artDetalle;
        public Detalle(Articulo _artDetalle)
        {
            ServiceDB service = new ServiceDB();

            InitializeComponent();
            artDetalle = _artDetalle;
            codigo.Text = _artDetalle.Codigo;
            nombre.Text = _artDetalle.Nombre;
            descripcion.Text = _artDetalle.Descripcion;
            marca.Text = _artDetalle.Marca.ToString();
            categoria.Text = _artDetalle.Categoria.ToString();
            try
            {
                imagenBox.Load(service.GetImgByArticuloId(_artDetalle.Id).ImagenUrl);
            }
            catch (Exception ex)
            {
                imagenBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx4xrkRCeiKCPwkflbkXd11W_2fzx34RemdWXmv8TXYWLT2SGtLfkqFCyBb_CBoNcNVBc&usqp=CAU");
            }
            //imagenBox.Load(service.GetImgByArticuloId(_artDetalle.Id).ImagenUrl);
            precio.Text = "$" + _artDetalle.Precio.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServiceDB service = new ServiceDB();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    service.Eliminar(artDetalle.Id);
                    Close();
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

            NuevoArticulo nuevoArticulo = new NuevoArticulo(artDetalle);
            DialogResult result = nuevoArticulo.ShowDialog();

            if (result == DialogResult.OK && nuevoArticulo.ArticuloModificado != null)
            {
                artDetalle = nuevoArticulo.ArticuloModificado;

                codigo.Text = artDetalle.Codigo;
                nombre.Text = artDetalle.Nombre;
                descripcion.Text = artDetalle.Descripcion;
                marca.Text = artDetalle.Marca.ToString();
                categoria.Text = artDetalle.Categoria.ToString();
                precio.Text = "$" + artDetalle.Precio.ToString();


                try
                {
                    imagenBox.Load(service.GetImgByArticuloId(artDetalle.Id).ImagenUrl);
                }
                catch (Exception ex)
                {
                    imagenBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx4xrkRCeiKCPwkflbkXd11W_2fzx34RemdWXmv8TXYWLT2SGtLfkqFCyBb_CBoNcNVBc&usqp=CAU");
                }
            }
        }

    }
}
