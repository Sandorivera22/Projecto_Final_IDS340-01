using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using WindowsFormsProductos.Modelo_Prod;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsProductos.Logica_Prod
{
    public class ProductoLogica
    {
        // Se establece la conexion con la base de datos
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ProductoLogica _instancia = null;

        public ProductoLogica()
        {

        }
        public static ProductoLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ProductoLogica();
                }
                return _instancia;
            }
        }
        public bool ExisteProducto(int id)
        {
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos 
                string query = "SELECT COUNT(*) FROM Producto WHERE id = @_id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", id));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public Boolean Guardar(Producto obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "El producto no puede ser nulo.");
            }
            // Se comprueba que los campos no sean nulos
            if (string.IsNullOrWhiteSpace(obj.nombre) ||
                string.IsNullOrWhiteSpace(obj.categoria) ||
                string.IsNullOrWhiteSpace(obj.proveedor))
            {
                throw new ArgumentException("Los campos nombre, categoría y proveedor no pueden estar vacíos.");
            }
            // Se verifica que el precio sea mayor de 0
            if (obj.precio <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0.");
            }
            // Se verifica que el stock sea positivo 
            if (obj.stock < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }
            if (ExisteProducto(obj.id))
            {
                throw new Exception($"El producto con ID {obj.id} ya existe.");
            }

            bool respuesta = true;

            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se insertan los valores dados en cada columna de nuestra tabla
                string query = "insert into Producto(nombre, categoria, precio, stock, proveedor) values (@_nombre,@_categoria,@_precio,@_stock,@_proveedor)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@_categoria", obj.categoria));
                cmd.Parameters.Add(new SQLiteParameter("@_precio", obj.precio));
                cmd.Parameters.Add(new SQLiteParameter("@_stock", obj.stock));
                cmd.Parameters.Add(new SQLiteParameter("@_proveedor", obj.proveedor));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Producto> Listar()
        {
            List<Producto> olista = new List<Producto>();
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos
                string query = "select id,nombre,categoria,precio,stock,proveedor from Producto";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Producto()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            nombre = dr["nombre"].ToString(),
                            categoria = dr["categoria"].ToString(),
                            precio = double.Parse(dr["precio"].ToString()),
                            stock = int.Parse(dr["stock"].ToString()),
                            proveedor = dr["proveedor"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }
        public Boolean Editar(Producto obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "El producto no puede ser nulo.");
            }
            // Se comprueba que los campos no sean nulos
            if (string.IsNullOrWhiteSpace(obj.nombre) ||
                string.IsNullOrWhiteSpace(obj.categoria) ||
                string.IsNullOrWhiteSpace(obj.proveedor))
            {
                throw new ArgumentException("Los campos nombre, categoría y proveedor no pueden estar vacíos.");
            }
            // Se verifica que el precio sea mayor de 0
            if (obj.precio <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0.");
            }
            // Se verifica que el stock sea positivo 
            if (obj.stock < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }
            if (ExisteProducto(obj.id))
            {
                throw new Exception($"El producto con ID {obj.id} ya existe.");
            }
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se actualizan los datos en cada uno de los campos
                string query = "Update Producto set nombre = @_nombre, categoria = @_categoria, precio = @_precio, stock = @_stock, proveedor = @_proveedor where id = @_id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@_categoria", obj.categoria));
                cmd.Parameters.Add(new SQLiteParameter("@_precio", obj.precio));
                cmd.Parameters.Add(new SQLiteParameter("@_stock", obj.stock));
                cmd.Parameters.Add(new SQLiteParameter("@_proveedor", obj.proveedor));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public Boolean Eliminar(Producto obj)
        {
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se elimina la fila deseada usando el id
                string query = "delete from Producto where id = @_id";

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
        public List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos
                string query = "SELECT nombre FROM Categorias";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    categorias.Add(dr["nombre"].ToString());
                }
            }

            return categorias;
        }

        public List<string> ObtenerProveedores()
        {
            List<string> proveedores = new List<string>();
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos
                string query = "SELECT nombre_empresa FROM Proveedores";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    proveedores.Add(dr["nombre_empresa"].ToString());
                }
            }

            return proveedores;
        }
    }
}

