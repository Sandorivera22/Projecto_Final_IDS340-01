namespace Projecto_Final_Gestion_Inventario
{
    partial class Form_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.txtb_guardar = new System.Windows.Forms.Button();
            this.txtb_stock = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txtb_precio = new System.Windows.Forms.TextBox();
            this.txtb_nombre = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_tcategorias = new System.Windows.Forms.Button();
            this.btn_tproveedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(396, 36);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(140, 33);
            this.cmb_categoria.TabIndex = 54;
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(966, 38);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(140, 33);
            this.cmb_proveedor.TabIndex = 53;
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(12, 222);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 82;
            this.dgv_productos.RowTemplate.Height = 33;
            this.dgv_productos.Size = new System.Drawing.Size(1629, 488);
            this.dgv_productos.TabIndex = 52;
            // 
            // txtb_guardar
            // 
            this.txtb_guardar.Location = new System.Drawing.Point(7, 101);
            this.txtb_guardar.Name = "txtb_guardar";
            this.txtb_guardar.Size = new System.Drawing.Size(140, 78);
            this.txtb_guardar.TabIndex = 51;
            this.txtb_guardar.Text = "Guardar";
            this.txtb_guardar.UseVisualStyleBackColor = true;
            this.txtb_guardar.Click += new System.EventHandler(this.txtb_guardar_Click);
            // 
            // txtb_stock
            // 
            this.txtb_stock.Location = new System.Drawing.Point(772, 38);
            this.txtb_stock.Name = "txtb_stock";
            this.txtb_stock.Size = new System.Drawing.Size(140, 31);
            this.txtb_stock.TabIndex = 50;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(765, 10);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(63, 25);
            this.lbl_stock.TabIndex = 49;
            this.lbl_stock.Text = "stock";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(965, 10);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(109, 25);
            this.lbl_proveedor.TabIndex = 48;
            this.lbl_proveedor.Text = "proveedor";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(358, 101);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(140, 78);
            this.btn_eliminar.TabIndex = 47;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(178, 101);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(140, 78);
            this.btn_editar.TabIndex = 46;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txtb_precio
            // 
            this.txtb_precio.Location = new System.Drawing.Point(598, 36);
            this.txtb_precio.Name = "txtb_precio";
            this.txtb_precio.Size = new System.Drawing.Size(140, 31);
            this.txtb_precio.TabIndex = 45;
            // 
            // txtb_nombre
            // 
            this.txtb_nombre.Location = new System.Drawing.Point(208, 36);
            this.txtb_nombre.Name = "txtb_nombre";
            this.txtb_nombre.Size = new System.Drawing.Size(140, 31);
            this.txtb_nombre.TabIndex = 44;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(12, 36);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(140, 31);
            this.txtb_id.TabIndex = 43;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(598, 8);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(71, 25);
            this.lbl_precio.TabIndex = 42;
            this.lbl_precio.Text = "precio";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(406, 8);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(101, 25);
            this.lbl_categoria.TabIndex = 41;
            this.lbl_categoria.Text = "categoria";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(215, 8);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(84, 25);
            this.lbl_nombre.TabIndex = 40;
            this.lbl_nombre.Text = "nombre";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(22, 8);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(29, 25);
            this.lbl_id.TabIndex = 39;
            this.lbl_id.Text = "id";
            // 
            // btn_tcategorias
            // 
            this.btn_tcategorias.Location = new System.Drawing.Point(1159, 122);
            this.btn_tcategorias.Name = "btn_tcategorias";
            this.btn_tcategorias.Size = new System.Drawing.Size(182, 78);
            this.btn_tcategorias.TabIndex = 55;
            this.btn_tcategorias.Text = "Tabla de categorias";
            this.btn_tcategorias.UseVisualStyleBackColor = true;
            this.btn_tcategorias.Click += new System.EventHandler(this.btn_tcategorias_Click);
            // 
            // btn_tproveedores
            // 
            this.btn_tproveedores.Location = new System.Drawing.Point(1159, 12);
            this.btn_tproveedores.Name = "btn_tproveedores";
            this.btn_tproveedores.Size = new System.Drawing.Size(182, 78);
            this.btn_tproveedores.TabIndex = 56;
            this.btn_tproveedores.Text = "Tabla de proveedores";
            this.btn_tproveedores.UseVisualStyleBackColor = true;
            this.btn_tproveedores.Click += new System.EventHandler(this.btn_tproveedores_Click);
            // 
            // Form_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 762);
            this.Controls.Add(this.btn_tproveedores);
            this.Controls.Add(this.btn_tcategorias);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.txtb_guardar);
            this.Controls.Add(this.txtb_stock);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txtb_precio);
            this.Controls.Add(this.txtb_nombre);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form_Productos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button txtb_guardar;
        private System.Windows.Forms.TextBox txtb_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txtb_precio;
        private System.Windows.Forms.TextBox txtb_nombre;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_tcategorias;
        private System.Windows.Forms.Button btn_tproveedores;
    }
}

