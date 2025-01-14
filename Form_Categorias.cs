using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCategorias.Logica_Cat;
using WindowsFormsCategorias.Modelo_Cat;

namespace Projecto_Final_Gestion_Inventario
{
    public partial class Form_Categorias : Form
    {
        public Form_Categorias()
        {
            InitializeComponent();
        }

        private void Form_Categorias_Load(object sender, EventArgs e)
        {
            mostrar_Categoria();
        }

        private void txtb_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtb_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txtb_descripcion.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }
                Categoria objeto = new Categoria()
                {
                    //id = int.Parse(txtb_id.Text),
                    nombre = txtb_nombre.Text,
                    descripcion = txtb_descripcion.Text,
                };

                Boolean respuesta = CategoriaLogica.Instancia.Guardar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_Categoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Categoria objeto = new Categoria()
            {
                id = int.Parse(txtb_id.Text),
                nombre = txtb_nombre.Text,
                descripcion = txtb_descripcion.Text,
            };

            Boolean respuesta = CategoriaLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Categoria();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Categoria objeto = new Categoria()
            {
                id = int.Parse(txtb_id.Text),
            };

            Boolean respuesta = CategoriaLogica.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_Categoria();
            }
        }
        public void mostrar_Categoria()
        {
            dgv_categorias.DataSource = null;
            dgv_categorias.DataSource = CategoriaLogica.Instancia.Listar();
        }
        public void limpiar()
        {
            txtb_id.Text = "";
            txtb_nombre.Text = "";
            txtb_descripcion.Text = "";
            txtb_nombre.Focus();

        }

    }
}
