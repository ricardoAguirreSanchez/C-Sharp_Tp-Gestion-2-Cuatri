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
            this.lab_codigo_rol = new System.Windows.Forms.Label();
            this.lab_Nombre = new System.Windows.Forms.Label();
            this.tex_Codigo_rol = new System.Windows.Forms.TextBox();
            this.tex_Descripcion = new System.Windows.Forms.TextBox();
            this.but_Agregar = new System.Windows.Forms.Button();
            this.but_Verificar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gro_Datos_rol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gro_Datos_rol
            // 
            this.gro_Datos_rol.Controls.Add(this.listBox1);
            this.gro_Datos_rol.Controls.Add(this.but_Verificar);
            this.gro_Datos_rol.Controls.Add(this.lab_Funcionalidad);
            this.gro_Datos_rol.Controls.Add(this.lab_codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.lab_Nombre);
            this.gro_Datos_rol.Controls.Add(this.tex_Codigo_rol);
            this.gro_Datos_rol.Controls.Add(this.tex_Descripcion);
            this.gro_Datos_rol.Controls.Add(this.but_Agregar);
            this.gro_Datos_rol.Location = new System.Drawing.Point(12, 12);
            this.gro_Datos_rol.Name = "gro_Datos_rol";
            this.gro_Datos_rol.Size = new System.Drawing.Size(287, 195);
            this.gro_Datos_rol.TabIndex = 25;
            this.gro_Datos_rol.TabStop = false;
            this.gro_Datos_rol.Text = "Datos del rol";
            // 
            // lab_Funcionalidad
            // 
            this.lab_Funcionalidad.AutoSize = true;
            this.lab_Funcionalidad.Location = new System.Drawing.Point(20, 102);
            this.lab_Funcionalidad.Name = "lab_Funcionalidad";
            this.lab_Funcionalidad.Size = new System.Drawing.Size(73, 13);
            this.lab_Funcionalidad.TabIndex = 21;
            this.lab_Funcionalidad.Text = "Funcionalidad";
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
            // lab_Nombre
            // 
            this.lab_Nombre.AutoSize = true;
            this.lab_Nombre.Location = new System.Drawing.Point(23, 61);
            this.lab_Nombre.Name = "lab_Nombre";
            this.lab_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lab_Nombre.TabIndex = 1;
            this.lab_Nombre.Text = "Nombre";
            this.lab_Nombre.Click += new System.EventHandler(this.lab_Descripcion_Click);
            // 
            // tex_Codigo_rol
            // 
            this.tex_Codigo_rol.Location = new System.Drawing.Point(104, 25);
            this.tex_Codigo_rol.Name = "tex_Codigo_rol";
            this.tex_Codigo_rol.Size = new System.Drawing.Size(40, 20);
            this.tex_Codigo_rol.TabIndex = 7;
            // 
            // tex_Descripcion
            // 
            this.tex_Descripcion.Location = new System.Drawing.Point(104, 61);
            this.tex_Descripcion.Name = "tex_Descripcion";
            this.tex_Descripcion.Size = new System.Drawing.Size(160, 20);
            this.tex_Descripcion.TabIndex = 8;
            // 
            // but_Agregar
            // 
            this.but_Agregar.Location = new System.Drawing.Point(150, 166);
            this.but_Agregar.Name = "but_Agregar";
            this.but_Agregar.Size = new System.Drawing.Size(103, 23);
            this.but_Agregar.TabIndex = 18;
            this.but_Agregar.Text = "Agregar";
            this.but_Agregar.UseVisualStyleBackColor = true;
            // 
            // but_Verificar
            // 
            this.but_Verificar.Location = new System.Drawing.Point(150, 23);
            this.but_Verificar.Name = "but_Verificar";
            this.but_Verificar.Size = new System.Drawing.Size(103, 23);
            this.but_Verificar.TabIndex = 22;
            this.but_Verificar.Text = "Verificar";
            this.but_Verificar.UseVisualStyleBackColor = true;
            this.but_Verificar.Click += new System.EventHandler(this.but_Verificar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(104, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 23;
            // 
            // frm_agregar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 229);
            this.Controls.Add(this.gro_Datos_rol);
            this.Name = "frm_agregar_rol";
            this.Text = "Agregar Rol Nuevo";
            this.Load += new System.EventHandler(this.frm_agregar_rol_Load);
            this.gro_Datos_rol.ResumeLayout(false);
            this.gro_Datos_rol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro_Datos_rol;
        private System.Windows.Forms.Button but_Verificar;
        private System.Windows.Forms.Label lab_Funcionalidad;
        private System.Windows.Forms.Label lab_codigo_rol;
        private System.Windows.Forms.Label lab_Nombre;
        private System.Windows.Forms.TextBox tex_Codigo_rol;
        private System.Windows.Forms.TextBox tex_Descripcion;
        private System.Windows.Forms.Button but_Agregar;
        private System.Windows.Forms.ListBox listBox1;
    }
}