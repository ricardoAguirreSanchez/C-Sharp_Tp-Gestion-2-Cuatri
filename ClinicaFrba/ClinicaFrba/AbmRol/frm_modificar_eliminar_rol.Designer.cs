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
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_funcionalidades_rol = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_funcionalidades_sistema = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cb_habilitado_si_no = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_guardar_cambios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.but_Eliminar_rol = new System.Windows.Forms.Button();
            this.gro_Datos_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionalidades_rol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionalidades_sistema)).BeginInit();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.label4);
            this.gro_Datos_rol.Controls.Add(this.dgv_funcionalidades_rol);
            this.gro_Datos_rol.Controls.Add(this.dgv_funcionalidades_sistema);
            this.gro_Datos_rol.Controls.Add(this.cb_habilitado_si_no);
            this.gro_Datos_rol.Controls.Add(this.label2);
            this.gro_Datos_rol.Controls.Add(this.but_guardar_cambios);
            this.gro_Datos_rol.Controls.Add(this.label1);
            this.gro_Datos_rol.Controls.Add(this.lab_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.label3);
            this.gro_Datos_rol.Controls.Add(this.tex_Nombre);
            this.gro_Datos_rol.Controls.Add(this.but_Eliminar_rol);
            this.gro_Datos_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(570, 313);
            this.gro_Datos_rol.TabIndex = 25;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
            this.gro_Datos_rol.Enter += new System.EventHandler(this.gro_Datos_rol_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Listado de funcionalidades existentes en el sistema ";
            // 
            // dgv_funcionalidades_rol
            // 
            this.dgv_funcionalidades_rol.AllowUserToAddRows = false;
            this.dgv_funcionalidades_rol.AllowUserToDeleteRows = false;
            this.dgv_funcionalidades_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionalidades_rol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgv_funcionalidades_rol.Location = new System.Drawing.Point(26, 128);
            this.dgv_funcionalidades_rol.Name = "dgv_funcionalidades_rol";
            this.dgv_funcionalidades_rol.Size = new System.Drawing.Size(248, 144);
            this.dgv_funcionalidades_rol.TabIndex = 28;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Elegir";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dgv_funcionalidades_sistema
            // 
            this.dgv_funcionalidades_sistema.AllowUserToAddRows = false;
            this.dgv_funcionalidades_sistema.AllowUserToDeleteRows = false;
            this.dgv_funcionalidades_sistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionalidades_sistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.dgv_funcionalidades_sistema.Location = new System.Drawing.Point(294, 64);
            this.dgv_funcionalidades_sistema.Name = "dgv_funcionalidades_sistema";
            this.dgv_funcionalidades_sistema.Size = new System.Drawing.Size(259, 187);
            this.dgv_funcionalidades_sistema.TabIndex = 27;
            this.dgv_funcionalidades_sistema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionalidades_sistema_CellContentClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            // 
            // cb_habilitado_si_no
            // 
            this.cb_habilitado_si_no.FormattingEnabled = true;
            this.cb_habilitado_si_no.Location = new System.Drawing.Point(90, 64);
            this.cb_habilitado_si_no.Name = "cb_habilitado_si_no";
            this.cb_habilitado_si_no.Size = new System.Drawing.Size(79, 21);
            this.cb_habilitado_si_no.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Habilitado:";
            // 
            // but_guardar_cambios
            // 
            this.but_guardar_cambios.Location = new System.Drawing.Point(351, 284);
            this.but_guardar_cambios.Name = "but_guardar_cambios";
            this.but_guardar_cambios.Size = new System.Drawing.Size(109, 23);
            this.but_guardar_cambios.TabIndex = 24;
            this.but_guardar_cambios.Text = "Guardar cambios";
            this.but_guardar_cambios.UseVisualStyleBackColor = true;
            this.but_guardar_cambios.Click += new System.EventHandler(this.but_guardar_cambios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "que puede agregar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_Descripcion
            // 
            this.lab_Descripcion.AutoSize = true;
            this.lab_Descripcion.Location = new System.Drawing.Point(23, 32);
            this.lab_Descripcion.Name = "lab_Descripcion";
            this.lab_Descripcion.Size = new System.Drawing.Size(44, 13);
            this.lab_Descripcion.TabIndex = 1;
            this.lab_Descripcion.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado de funcionalidades del rol que puede borrar:";
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(90, 32);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(160, 20);
            this.tex_Nombre.TabIndex = 8;
            // 
            // but_Eliminar_rol
            // 
            this.but_Eliminar_rol.Location = new System.Drawing.Point(478, 284);
            this.but_Eliminar_rol.Name = "but_Eliminar_rol";
            this.but_Eliminar_rol.Size = new System.Drawing.Size(75, 23);
            this.but_Eliminar_rol.TabIndex = 18;
            this.but_Eliminar_rol.Text = "Eliminar rol";
            this.but_Eliminar_rol.UseVisualStyleBackColor = true;
            this.but_Eliminar_rol.Click += new System.EventHandler(this.but_Eliminar_rol_Click);
            // 
            // frm_modificar_eliminar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 337);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "frm_modificar_eliminar_rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar / Eliminar Rol";
            this.Load += new System.EventHandler(this.frm_modificar_eliminar_rol_Load);
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionalidades_rol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionalidades_sistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Button but_guardar_cambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Eliminar_rol;
        private System.Windows.Forms.ComboBox cb_habilitado_si_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_Nombre;
        private System.Windows.Forms.DataGridView dgv_funcionalidades_rol;
        private System.Windows.Forms.DataGridView dgv_funcionalidades_sistema;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.Label label4;
    }
}