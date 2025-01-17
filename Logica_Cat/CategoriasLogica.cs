using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using WindowsFormsCategorias.Modelo_Cat;
using System.Data.SQLite;


namespace WindowsFormsCategorias.Logica_Cat
{
    public class CategoriaLogica
    {
        // Se establece la conexion con la base de datos
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static CategoriaLogica _instancia = null;

        public CategoriaLogica()
        {

        }
        public static CategoriaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia= new CategoriaLogica();
                }
                return _instancia;
            }  
        }
        public bool ExisteCategoria(int id)
        {
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos 
                string query = "SELECT COUNT(*) FROM Categorias WHERE id = @_id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", id));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public Boolean Guardar(Categoria obj) 
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "El Categoria no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(obj.nombre) ||
                string.IsNullOrWhiteSpace(obj.descripcion))
            {
                throw new ArgumentException("Los campos nombre, categoría y proveedor no pueden estar vacíos.");
            }
            if (ExisteCategoria(obj.id))
            {
                throw new Exception($"El Categoria con ID {obj.id} ya existe.");
            }

            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se insertan los valores dados en cada columna de nuestra tabla
                string query = "insert into Categorias(nombre, descripcion) values (@_nombre,@_descripcion)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@_descripcion", obj.descripcion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Categoria> Listar()
        {
            List<Categoria> olista = new List<Categoria>();
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos
                string query = "select id,nombre,descripcion from Categorias";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Categoria()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            nombre = dr["nombre"].ToString(),
                            descripcion = dr["descripcion"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }
        public Boolean Editar(Categoria obj)
        {
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se actualizan los datos en cada uno de los campos
                string query = "Update Categorias set nombre = @_nombre, descripcion = @_descripcion where id = @_id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@_descripcion", obj.descripcion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public Boolean Eliminar(Categoria obj)
        {
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se elimina la fila deseada usando el id
                string query = "delete from Categorias where id = @_id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
