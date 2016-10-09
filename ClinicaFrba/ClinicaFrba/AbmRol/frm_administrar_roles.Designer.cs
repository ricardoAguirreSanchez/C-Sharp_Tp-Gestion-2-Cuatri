namespace ClinicaFrba.AbmRol
{
    partial class frm_administrar_roles
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
            this.gro_Elegir_rol = new System.Windows.Forms.GroupBox();
            this.but_Buscar_roles_existentes = new System.Windows.Forms.Button();
            this.dgv_Listado_roles = new System.Windows.Forms.DataGridView();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.but_Modificar_eliminar_rol = new System.Windows.Forms.Button();
            this.gro_Elegir_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_roles)).BeginInit();
            this.SuspendLayout();
            // 
            // gro_Elegir_rol
            // 
            this.gro_Elegir_rol.Controls.Add(this.but_Buscar_roles_existentes);
            this.gro_Elegir_rol.Controls.Add(this.dgv_Listado_roles);
            this.gro_Elegir_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Elegir_rol.Name = "gro_Elegir_rol";
            this.gro_Elegir_rol.Size = new System.Drawing.Size(291, 185);
            this.gro_Elegir_rol.TabIndex = 26;
            this.gro_Elegir_rol.TabStop = false;
            this.gro_Elegir_rol.Text = "Elegir rol";
            // 
            // but_Buscar_roles_existentes
            // 
            this.but_Buscar_roles_existentes.Location = new System.Drawing.Point(19, 24);
            this.but_Buscar_roles_existentes.Name = "but_Buscar_roles_existentes";
            this.but_Buscar_roles_existentes.Size = new System.Drawing.Size(139, 23);
            this.but_Buscar_roles_existentes.TabIndex = 15;
            this.but_Buscar_roles_existentes.Text = "Buscar roles existentes";
            this.but_Buscar_roles_existentes.UseVisualStyleBackColor = true;
            this.but_Buscar_roles_existentes.Click += new System.EventHandler(this.but_Buscar_roles_existentes_Click);
            // 
            // dgv_Listado_roles
            // 
            this.dgv_Listado_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listado_roles.Location = new System.Drawing.Point(19, 53);
            this.dgv_Listado_roles.MultiSelect = false;
            this.dgv_Listado_roles.Name = "dgv_Listado_roles";
            this.dgv_Listado_roles.RowHeadersVisible = false;
            this.dgv_Listado_roles.Size = new System.Drawing.Size(231, 104);
            this.dgv_Listado_roles.TabIndex = 22;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(31, 203);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(119, 35);
            this.but_Agregar.TabIndex = 25;
            this.but_Agregar.Text = "Agregar nuevo rol";
            this.but_Agregar.UseVisualStyleBackColor = true;
            this.but_Agregar.Click += new System.EventHandler(this.but_Agregar_Click);
            // 
            // but_Modificar_eliminar_rol
            // 
            this.but_Modificar_eliminar_rol.Location = new System.Drawing.Point(159, 203);
            this.but_Modificar_eliminar_rol.Name = "but_Modificar_eliminar_rol";
            this.but_Modificar_eliminar_rol.Size = new System.Drawing.Size(119, 35);
            this.but_Modificar_eliminar_rol.TabIndex = 27;
            this.but_Modificar_eliminar_rol.Text = "Modificar / Eliminar rol";
            this.but_Modificar_eliminar_rol.UseVisualStyleBackColor = true;
            this.but_Modificar_eliminar_rol.Click += new System.EventHandler(this.but_Modificar_eliminar_rol_Click);
            // 
            // frm_administrar_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 278);
            this.Controls.Add(this.but_Modificar_eliminar_rol);
            this.Controls.Add(this.gro_Elegir_rol);
            this.Controls.Add(this.but_Agregar);
            this.Name = "frm_administrar_roles";
            this.Text = "Administrar Roles";
            this.Load += new System.EventHandler(this.frm_administrar_roles_Load);
            this.gro_Elegir_rol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listado_roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Elegir_rol;
        private System.Windows.Forms.Button but_Buscar_roles_existentes;
        private System.Windows.Forms.DataGridView dgv_Listado_roles;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.Button but_Modificar_eliminar_rol;

    }
}