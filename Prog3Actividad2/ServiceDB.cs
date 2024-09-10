using Dominio; using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
