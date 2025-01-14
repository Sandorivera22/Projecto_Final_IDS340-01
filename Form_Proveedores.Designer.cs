namespace Projecto_Final_Gestion_Inventario
{
    partial class Form_Proveedores
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
            this.txtb_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txtb_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txtb_contacto = new System.Windows.Forms.TextBox();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.txtb_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txtb_nombre = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_telefono
            // 
            this.txtb_telefono.Location = new System.Drawing.Point(751, 55);
            this.txtb_telefono.Name = "txtb_telefono";
            this.txtb_telefono.Size = new System.Drawing.Size(146, 31);
            this.txtb_telefono.TabIndex = 79;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(763, 27);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(89, 25);
            this.lbl_telefono.TabIndex = 78;
            this.lbl_telefono.Text = "telefono";
            // 
            // txtb_direccion
            // 
            this.txtb_direccion.Location = new System.Drawing.Point(568, 55);
            this.txtb_direccion.Name = "txtb_direccion";
            this.txtb_direccion.Size = new System.Drawing.Size(146, 31);
            this.txtb_direccion.TabIndex = 77;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(590, 27);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(99, 25);
            this.lbl_direccion.TabIndex = 76;
            this.lbl_direccion.Text = "dirección";
            // 
            // txtb_contacto
            // 
            this.txtb_contacto.Location = new System.Drawing.Point(405, 55);
            this.txtb_contacto.Name = "txtb_contacto";
            this.txtb_contacto.Size = new System.Drawing.Size(146, 31);
            this.txtb_contacto.TabIndex = 75;
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(31, 273);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.RowHeadersWidth = 82;
            this.dgv_proveedores.RowTemplate.Height = 33;
            this.dgv_proveedores.Size = new System.Drawing.Size(1151, 403);
            this.dgv_proveedores.TabIndex = 74;
            this.dgv_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedores_CellContentClick);
            // 
            // txtb_guardar
            // 
            this.txtb_guardar.Location = new System.Drawing.Point(41, 133);
            this.txtb_guardar.Name = "txtb_guardar";
            this.txtb_guardar.Size = new System.Drawing.Size(113, 84);
            this.txtb_guardar.TabIndex = 73;
            this.txtb_guardar.Text = "Guardar";
            this.txtb_guardar.UseVisualStyleBackColor = true;
            this.txtb_guardar.Click += new System.EventHandler(this.txtb_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(398, 133);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 84);
            this.btn_eliminar.TabIndex = 72;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(204, 133);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(123, 84);
            this.btn_editar.TabIndex = 71;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txtb_nombre
            // 
            this.txtb_nombre.Location = new System.Drawing.Point(223, 55);
            this.txtb_nombre.Name = "txtb_nombre";
            this.txtb_nombre.Size = new System.Drawing.Size(146, 31);
            this.txtb_nombre.TabIndex = 70;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(31, 55);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(142, 31);
            this.txtb_id.TabIndex = 69;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Location = new System.Drawing.Point(427, 27);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(94, 25);
            this.lbl_contacto.TabIndex = 68;
            this.lbl_contacto.Text = "contacto";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(236, 27);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(84, 25);
            this.lbl_nombre.TabIndex = 67;
            this.lbl_nombre.Text = "nombre";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(43, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(29, 25);
            this.lbl_id.TabIndex = 66;
            this.lbl_id.Text = "id";
            // 
            // Form_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 709);
            this.Controls.Add(this.txtb_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txtb_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txtb_contacto);
            this.Controls.Add(this.dgv_proveedores);
            this.Controls.Add(this.txtb_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txtb_nombre);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.lbl_contacto);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form_Proveedores";
            this.Text = "Form_Proveedores";
            this.Load += new System.EventHandler(this.Form_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txtb_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txtb_contacto;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.Button txtb_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txtb_nombre;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_id;
    }
}