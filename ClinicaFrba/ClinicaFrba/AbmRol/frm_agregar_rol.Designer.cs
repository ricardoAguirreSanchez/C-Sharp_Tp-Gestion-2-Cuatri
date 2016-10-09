namespace ClinicaFrba.AbmRol
{
    partial class frm_agregar_rol
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
            this.lab_Funcionalidad = new System.Windows.Forms.Label();
            this.lab_Nombre = new System.Windows.Forms.Label();
            this.tex_Descripcion = new System.Windows.Forms.TextBox();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gro_Datos_rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.dataGridView1);
            this.gro_Datos_rol.Controls.Add(this.lab_Funcionalidad);
            this.gro_Datos_rol.Controls.Add(this.lab_Nombre);
            this.gro_Datos_rol.Controls.Add(this.tex_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.but_Agregar);
            this.gro_Datos_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(318, 396);
            this.gro_Datos_rol.TabIndex = 25;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
            this.gro_Datos_rol.Enter += new System.EventHandler(this.gro_Datos_rol_Enter);
            // 
            // lab_Funcionalidad
            // 
            this.lab_Funcionalidad.AutoSize = true;
            this.lab_Funcionalidad.Location = new System.Drawing.Point(15, 75);
            this.lab_Funcionalidad.Name = "lab_Funcionalidad";
            this.lab_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.lab_Funcionalidad.TabIndex = 21;
            this.lab_Funcionalidad.Text = "Funcionalidad";
            // 
            // lab_Nombre
            // 
            this.lab_Nombre.AutoSize = true;
            this.lab_Nombre.Location = new System.Drawing.Point(18, 34);
            this.lab_Nombre.Name = "lab_Nombre";
            this.lab_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lab_Nombre.TabIndex = 1;
            this.lab_Nombre.Text = "Nombre";
            this.lab_Nombre.Click += new System.EventHandler(this.lab_Descripcion_Click);
            // 
            // tex_Descripcion
            // 
            this.tex_Descripcion.Location = new System.Drawing.Point(99, 34);
            this.tex_Descripcion.Name = "tex_Descripcion";
            this.tex_Descripcion.Size = new System.Drawing.Size(160, 20);
            this.tex_Descripcion.TabIndex = 8;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(88, 314);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(103, 23);
            this.but_Agregar.TabIndex = 18;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            this.but_Agregar.Click += new System.EventHandler(this.but_Agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.dataGridView1.Location = new System.Drawing.Point(18, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(283, 217);
            this.dataGridView1.TabIndex = 22;
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Column1";
            this.Elegir.Name = "Elegir";
            // 
            // frm_agregar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 420);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "frm_agregar_rol";
            this.Text = "Agregar Rol Nuevo";
            this.Load += new System.EventHandler(this.frm_agregar_rol_Load);
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Label lab_Funcionalidad;
        private System.Windows.Forms.Label lab_Nombre;
        private System.Windows.Forms.TextBox tex_Descripcion;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
    }
}