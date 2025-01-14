using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProductos.Logica_Prod;
using WindowsFormsProductos.Modelo_Prod;

namespace Projecto_Final_Gestion_Inventario
{
    public partial class Form_Productos : Form
    {
        public Form_Productos()
        {
            InitializeComponent();
        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            mostrar_producto();
        }

        private void txtb_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtb_nombre.Text) ||
                    string.IsNullOrWhiteSpace(cmb_categoria.Text) ||
                    string.IsNullOrWhiteSpace(txtb_precio.Text) ||
                    string.IsNullOrWhiteSpace(txtb_stock.Text) ||
                    string.IsNullOrWhiteSpace(cmb_proveedor.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                double precio;
                if (!double.TryParse(txtb_precio.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.");
                    return;
                }

                int stock;
                if (!int.TryParse(txtb_stock.Text, out stock))
                {
                    MessageBox.Show("El stock debe ser un número entero.");
                    return;
                }
                Producto objeto = new Producto()
                {
                    //id = int.Parse(txtb_id.Text),
                    nombre = txtb_nombre.Text,
                    categoria = cmb_categoria.Text,
                    precio = double.Parse(txtb_precio.Text),
                    stock = int.Parse(txtb_stock.Text),
                    proveedor = cmb_proveedor.Text,
                };

                Boolean respuesta = ProductoLogica.Instancia.Guardar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_producto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Producto objeto = new Producto()
            {
                id = int.Parse(txtb_id.Text),
                nombre = txtb_nombre.Text,
                categoria = cmb_categoria.Text,
                precio = double.Parse(txtb_precio.Text),
                stock = int.Parse(txtb_stock.Text),
                proveedor = cmb_proveedor.Text
            };

            Boolean respuesta = ProductoLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_producto();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Producto objeto = new Producto()
            {
                id = int.Parse(txtb_id.Text),
            };

            Boolean respuesta = ProductoLogica.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_producto();
            }
        }
        private void btn_tproveedores_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de proveedores
            Form_Proveedores formProveedores = new Form_Proveedores();

            // Muestra el formulario
            formProveedores.ShowDialog();
            CargarCategorias();
            CargarProveedores();
        }
        private void btn_tcategorias_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de categorías
            Form_Categorias formCategorias = new Form_Categorias();

            // Muestra el formulario
            formCategorias.ShowDialog();

            CargarCategorias();
            CargarProveedores();
        }
        public void mostrar_producto()
        {
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = ProductoLogica.Instancia.Listar();
            CargarCategorias();
            CargarProveedores();
        }
        public void limpiar()
        {
            txtb_id.Text = "";
            txtb_nombre.Text = "";
            cmb_categoria.Text = "";
            txtb_precio.Text = "";
            txtb_stock.Text = "";
            cmb_proveedor.Text = "";
            txtb_nombre.Focus();

        }
        private void CargarCategorias()
        {
            try
            {
                // Reinicia la ComboBox
                cmb_categoria.DataSource = null;

                // Obtiene las categorías desde la lógica
                List<string> categorias = ProductoLogica.Instancia.ObtenerCategorias();

                // Verifica si hay categorías disponibles
                if (categorias != null && categorias.Count > 0)
                {
                    cmb_categoria.DataSource = categorias;
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                // Reinicia la ComboBox
                cmb_proveedor.DataSource = null;

                // Obtiene los proveedores desde la lógica
                List<string> proveedores = ProductoLogica.Instancia.ObtenerProveedores();

                // Verifica si hay proveedores disponibles
                if (proveedores != null && proveedores.Count > 0)
                {
                    cmb_proveedor.DataSource = proveedores;
                }
                else
                {
                    MessageBox.Show("No se encontraron proveedores en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
