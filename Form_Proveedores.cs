using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProveedores.Logica_Prov;
using WindowsFormsProveedores.Modelo_Prov;

namespace Projecto_Final_Gestion_Inventario
{
    public partial class Form_Proveedores : Form
    {
        public Form_Proveedores()
        {
            InitializeComponent();
        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            mostrar_Proveedor();
        }

        private void dgv_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtb_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtb_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txtb_contacto.Text) ||
                    string.IsNullOrWhiteSpace(txtb_direccion.Text) ||
                    string.IsNullOrWhiteSpace(txtb_telefono.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                Proveedor objeto = new Proveedor()
                {
                    //id = int.Parse(txtb_id.Text),
                    nombre_empresa = txtb_nombre.Text,
                    contacto = txtb_contacto.Text,
                    direccion = txtb_direccion.Text,
                    telefono = txtb_telefono.Text,
                };

                Boolean respuesta = ProveedoresLogica.Instancia.Guardar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_Proveedor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Proveedor objeto = new Proveedor()
            {
                id = int.Parse(txtb_id.Text),
                nombre_empresa = txtb_nombre.Text,
                contacto = txtb_contacto.Text,
                direccion = txtb_direccion.Text,
                telefono = txtb_telefono.Text,
            };

            Boolean respuesta = ProveedoresLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Proveedor();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Proveedor objeto = new Proveedor()
            {
                id = int.Parse(txtb_id.Text),
            };

            Boolean respuesta = ProveedoresLogica.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Proveedor();
            }
        }
        public void mostrar_Proveedor()
        {
            dgv_proveedores.DataSource = null;
            dgv_proveedores.DataSource = ProveedoresLogica.Instancia.Listar();
        }
        public void limpiar()
        {
            txtb_id.Text = "";
            txtb_nombre.Text = "";
            txtb_contacto.Text = "";
            txtb_direccion.Text = "";
            txtb_telefono.Text = "";
            txtb_nombre.Focus();

        }
    }
}
