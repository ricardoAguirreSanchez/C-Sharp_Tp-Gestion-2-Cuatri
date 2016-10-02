namespace ClinicaFrba.AbmRol
{
    partial class frm_modificar_eliminar_rol
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
            this.gro_Datos_rol = new System.Windows.Forms.GroupBox();
            this.but_Borrar_funcionalidad = new System.Windows.Forms.Button();
            this.lab_codigo_rol = new System.Windows.Forms.Label();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_Codigo_rol = new System.Windows.Forms.TextBox();
            this.but_Agregar_funcionalidad = new System.Windows.Forms.Button();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.but_Eliminar_rol = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lis_Listado_funcionalidades_existentes_sistema = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_guardar_cambios = new System.Windows.Forms.Button();
            this.gro_Datos_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.but_guardar_cambios);
            this.gro_Datos_rol.Controls.Add(this.label1);
            this.gro_Datos_rol.Controls.Add(this.lis_Listado_funcionalidades_existentes_sistema);
            this.gro_Datos_rol.Controls.Add(this.but_Borrar_funcionalidad);
            this.gro_Datos_rol.Controls.Add(this.lab_codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.lab_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.label3);
            this.gro_Datos_rol.Controls.Add(this.tex_Codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.but_Agregar_funcionalidad);
            this.gro_Datos_rol.Controls.Add(this.tex_Nombre);
            this.gro_Datos_rol.Controls.Add(this.but_Eliminar_rol);
            this.gro_Datos_rol.Controls.Add(this.dataGridView1);
            this.gro_Datos_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(570, 293);
            this.gro_Datos_rol.TabIndex = 25;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
            // 
            // but_Borrar_funcionalidad
            // 
            this.but_Borrar_funcionalidad.Location = new System.Drawing.Point(23, 208);
            this.but_Borrar_funcionalidad.Name = "but_Borrar_funcionalidad";
            this.but_Borrar_funcionalidad.Size = new System.Drawing.Size(109, 23);
            this.but_Borrar_funcionalidad.TabIndex = 21;
            this.but_Borrar_funcionalidad.Text = "Borrar funcionalidad";
            this.but_Borrar_funcionalidad.UseVisualStyleBackColor = true;
            // 
            // lab_codigo_rol
            // 
            this.lab_codigo_rol.AutoSize = true;
            this.lab_codigo_rol.Location = new System.Drawing.Point(20, 28);
            this.lab_codigo_rol.Name = "lab_codigo_rol";
            this.lab_codigo_rol.Size = new System.Drawing.Size(54, 13);
            this.lab_codigo_rol.TabIndex = 0;
            this.lab_codigo_rol.Text = "Codigo rol";
            // 
            // lab_Descripcion
            // 
            this.lab_Descripcion.AutoSize = true;
            this.lab_Descripcion.Location = new System.Drawing.Point(23, 61);
            this.lab_Descripcion.Name = "lab_Descripcion";
            this.lab_Descripcion.Size = new System.Drawing.Size(44, 13);
            this.lab_Descripcion.TabIndex = 1;
            this.lab_Descripcion.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado de funcionalidades del rol";
            // 
            // tex_Codigo_rol
            // 
            this.tex_Codigo_rol.Location = new System.Drawing.Point(90, 27);
            this.tex_Codigo_rol.Name = "tex_Codigo_rol";
            this.tex_Codigo_rol.Size = new System.Drawing.Size(40, 20);
            this.tex_Codigo_rol.TabIndex = 7;
            // 
            // but_Agregar_funcionalidad
            // 
            this.but_Agregar_funcionalidad.Location = new System.Drawing.Point(320, 211);
            this.but_Agregar_funcionalidad.Name = "but_Agregar_funcionalidad";
            this.but_Agregar_funcionalidad.Size = new System.Drawing.Size(119, 23);
            this.but_Agregar_funcionalidad.TabIndex = 19;
            this.but_Agregar_funcionalidad.Text = "Agregar funcionalidad";
            this.but_Agregar_funcionalidad.UseVisualStyleBackColor = true;
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(90, 61);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(160, 20);
            this.tex_Nombre.TabIndex = 8;
            // 
            // but_Eliminar_rol
            // 
            this.but_Eliminar_rol.Location = new System.Drawing.Point(480, 264);
            this.but_Eliminar_rol.Name = "but_Eliminar_rol";
            this.but_Eliminar_rol.Size = new System.Drawing.Size(75, 23);
            this.but_Eliminar_rol.TabIndex = 18;
            this.but_Eliminar_rol.Text = "Eliminar rol";
            this.but_Eliminar_rol.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 70);
            this.dataGridView1.TabIndex = 16;
            // 
            // lis_Listado_funcionalidades_existentes_sistema
            // 
            this.lis_Listado_funcionalidades_existentes_sistema.FormattingEnabled = true;
            this.lis_Listado_funcionalidades_existentes_sistema.Location = new System.Drawing.Point(320, 45);
            this.lis_Listado_funcionalidades_existentes_sistema.Name = "lis_Listado_funcionalidades_existentes_sistema";
            this.lis_Listado_funcionalidades_existentes_sistema.Size = new System.Drawing.Size(214, 160);
            this.lis_Listado_funcionalidades_existentes_sistema.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Listado de funcionalidades existentes en el sistema";
            // 
            // but_guardar_cambios
            // 
            this.but_guardar_cambios.Location = new System.Drawing.Point(353, 264);
            this.but_guardar_cambios.Name = "but_guardar_cambios";
            this.but_guardar_cambios.Size = new System.Drawing.Size(109, 23);
            this.but_guardar_cambios.TabIndex = 24;
            this.but_guardar_cambios.Text = "Guardar cambios";
            this.but_guardar_cambios.UseVisualStyleBackColor = true;
            // 
            // frm_modificar_eliminar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 337);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "frm_modificar_eliminar_rol";
            this.Text = "Modificar / Eliminar Rol";
            this.Load += new System.EventHandler(this.frm_modificar_eliminar_rol_Load);
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Button but_guardar_cambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lis_Listado_funcionalidades_existentes_sistema;
        private System.Windows.Forms.Button but_Borrar_funcionalidad;
        private System.Windows.Forms.Label lab_codigo_rol;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_Codigo_rol;
        private System.Windows.Forms.Button but_Agregar_funcionalidad;
        private System.Windows.Forms.TextBox tex_Nombre;
        private System.Windows.Forms.Button but_Eliminar_rol;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}