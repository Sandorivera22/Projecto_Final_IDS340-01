namespace Projecto_Final_Gestion_Inventario
{
    partial class Form_Categorias
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
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.txtb_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txtb_descripcion = new System.Windows.Forms.TextBox();
            this.txtb_nombre = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(47, 294);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.RowHeadersWidth = 82;
            this.dgv_categorias.RowTemplate.Height = 33;
            this.dgv_categorias.Size = new System.Drawing.Size(1192, 326);
            this.dgv_categorias.TabIndex = 60;
            // 
            // txtb_guardar
            // 
            this.txtb_guardar.Location = new System.Drawing.Point(30, 168);
            this.txtb_guardar.Name = "txtb_guardar";
            this.txtb_guardar.Size = new System.Drawing.Size(123, 84);
            this.txtb_guardar.TabIndex = 59;
            this.txtb_guardar.Text = "Guardar";
            this.txtb_guardar.UseVisualStyleBackColor = true;
            this.txtb_guardar.Click += new System.EventHandler(this.txtb_guardar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(391, 168);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 84);
            this.btn_eliminar.TabIndex = 58;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(208, 168);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(123, 84);
            this.btn_editar.TabIndex = 57;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txtb_descripcion
            // 
            this.txtb_descripcion.Location = new System.Drawing.Point(404, 88);
            this.txtb_descripcion.Multiline = true;
            this.txtb_descripcion.Name = "txtb_descripcion";
            this.txtb_descripcion.Size = new System.Drawing.Size(316, 45);
            this.txtb_descripcion.TabIndex = 56;
            // 
            // txtb_nombre
            // 
            this.txtb_nombre.Location = new System.Drawing.Point(222, 88);
            this.txtb_nombre.Name = "txtb_nombre";
            this.txtb_nombre.Size = new System.Drawing.Size(146, 31);
            this.txtb_nombre.TabIndex = 55;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(30, 88);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(142, 31);
            this.txtb_id.TabIndex = 54;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(426, 60);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(122, 25);
            this.lbl_descripcion.TabIndex = 53;
            this.lbl_descripcion.Text = "descripcion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(235, 60);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(84, 25);
            this.lbl_nombre.TabIndex = 52;
            this.lbl_nombre.Text = "nombre";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(42, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(29, 25);
            this.lbl_id.TabIndex = 51;
            this.lbl_id.Text = "id";
            // 
            // Form_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 667);
            this.Controls.Add(this.dgv_categorias);
            this.Controls.Add(this.txtb_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txtb_descripcion);
            this.Controls.Add(this.txtb_nombre);
            this.Controls.Add(this.txtb_id);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form_Categorias";
            this.Text = "Form_Categorias";
            this.Load += new System.EventHandler(this.Form_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.Button txtb_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txtb_descripcion;
        private System.Windows.Forms.TextBox txtb_nombre;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_id;
    }
}