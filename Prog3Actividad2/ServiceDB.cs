using Dominio; using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog3Actividad2
{
    public class ServiceDB
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion AS Descripcion, M.Descripcion AS DescripcionMarca, C.Descripcion AS DescripcionCategoria, Precio " +
                    "FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                accesoDatos.EjecutarLectura();

                while(accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["DescripcionMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["DescripcionCategoria"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];
                    
                    articulos.Add(aux);
                    
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public void Agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.AgregarParametro("@Codigo", art.Codigo);
                datos.AgregarParametro("@Nombre", art.Nombre);
                datos.AgregarParametro("@Descripcion", art.Descripcion);
                datos.AgregarParametro("@IdMarca", art.Marca.Id);
                datos.AgregarParametro("@IdCategoria", art.Categoria.Id);
                datos.AgregarParametro("@Precio", art.Precio);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void AgregarImagen(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.AgregarParametro("@IdArticulo", img.IdArticulo);
                datos.AgregarParametro("@ImagenUrl", img.ImagenUrl);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int GetArticuloIdByCod(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            int Id = -1;
            try
            {
                datos.SetearConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @codigo");
                datos.AgregarParametro("@codigo", codigo);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    Id = (int)datos.Lector["Id"];
                }

                return Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Imagen GetImgByArticuloId(int IdArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            Imagen img = new Imagen();

            try
            {
                datos.SetearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.AgregarParametro("@IdArticulo", IdArticulo);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    img.Id = (int)datos.Lector["Id"];
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                }

                return img;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Marca> listarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion From MARCAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from ARTICULOS where id = @id");
                datos.AgregarParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
