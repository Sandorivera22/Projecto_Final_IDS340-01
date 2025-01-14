using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using WindowsFormsProveedores.Modelo_Prov;
using System.Data.SQLite;
using System.Drawing;


namespace WindowsFormsProveedores.Logica_Prov
{
    public class ProveedoresLogica
    {
        // Se establece la conexion con la base de datos
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ProveedoresLogica _instancia = null;

        public ProveedoresLogica()
        {

        }
        public static ProveedoresLogica Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia= new ProveedoresLogica();
                }
                return _instancia;
            }  
        }
        public bool ExisteProveedores(int id)
        {
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos 
                string query = "SELECT COUNT(*) FROM Proveedores WHERE id = @_id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", id));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public Boolean Guardar(Proveedor obj) 
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "El Proveedores no puede ser nulo.");
            }
            // Se comprueba que los campos no sean nulos
            if (string.IsNullOrWhiteSpace(obj.nombre_empresa) ||
                string.IsNullOrWhiteSpace(obj.contacto) ||
                string.IsNullOrWhiteSpace(obj.direccion))
            {
                throw new ArgumentException("Los campos nombre_empresa, contecto y direccion no pueden estar vacíos.");
            }
            // Se verifica que numero telefonico tenga 10 digitos y sean digitos
            if (string.IsNullOrWhiteSpace(obj.telefono) || obj.telefono.Length != 10 || !obj.telefono.All(char.IsDigit))
            {
                throw new ArgumentException("El teléfono debe ser un número de 10 dígitos.");
            }

            if (ExisteProveedores(obj.id))
            {
                throw new Exception($"El Proveedores con ID {obj.id} ya existe.");
            }

            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se insertan los valores dados en cada columna de nuestra tabla
                string query = "insert into Proveedores(nombre_empresa, contacto, direccion, telefono) values (@_nombre,@_contacto,@_direccion,@_telefono)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre_empresa));
                cmd.Parameters.Add(new SQLiteParameter("@_contacto", obj.contacto));
                cmd.Parameters.Add(new SQLiteParameter("@_direccion", obj.direccion));
                cmd.Parameters.Add(new SQLiteParameter("@_telefono", obj.telefono));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Proveedor> Listar()
        {
            List<Proveedor> olista = new List<Proveedor>();
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se selecciona la columna deseada de la base de datos
                string query = "select id,nombre_empresa,contacto,direccion,telefono from Proveedores";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Proveedor()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            nombre_empresa = dr["nombre_empresa"].ToString(),
                            contacto = dr["contacto"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            telefono = dr["telefono"].ToString(),
                        });
                    }
                }
            }
            return olista;
        }
        public Boolean Editar(Proveedor obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "El Proveedor no puede ser nulo.");
            }
            // Se comprueba que los campos no sean nulos
            if (string.IsNullOrWhiteSpace(obj.nombre_empresa) ||
                string.IsNullOrWhiteSpace(obj.contacto) ||
                string.IsNullOrWhiteSpace(obj.direccion))
            {
                throw new ArgumentException("Los campos nombre_empresa, contacto y dirección no pueden estar vacíos.");
            }
            // Se verifica que numero telefonico tenga 10 digitos y sean digitos
            if (string.IsNullOrWhiteSpace(obj.telefono) || obj.telefono.Length != 10 || !obj.telefono.All(char.IsDigit))
            {
                throw new ArgumentException("El teléfono debe ser un número de 10 dígitos.");
            }
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se actualizan los datos en cada uno de los campos
                string query = "Update Proveedores set nombre_empresa = @_nombre, contacto = @_contacto, direccion = @_direccion, telefono = @_telefono where id = @_id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@_id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@_nombre", obj.nombre_empresa));
                cmd.Parameters.Add(new SQLiteParameter("@_contacto", obj.contacto));
                cmd.Parameters.Add(new SQLiteParameter("@_direccion", obj.direccion));
                cmd.Parameters.Add(new SQLiteParameter("@_telefono", obj.telefono));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public Boolean Eliminar(Proveedor obj)
        {
            bool respuesta = true;
            // Se conecta a la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                // Se elimina la fila deseada usando el id
                string query = "delete from Proveedores where id = @_id";

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
