namespace ClinicaFrba
{
    partial class frm_tareas_administrativo
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
            this.but_registrar_llegada = new System.Windows.Forms.Button();
            this.but_consultar_estadisticas = new System.Windows.Forms.Button();
            this.but_administrar_afiliado = new System.Windows.Forms.Button();
            this.but_administrar_rol = new System.Windows.Forms.Button();
            this.group_por_afiliado = new System.Windows.Forms.GroupBox();
            this.but_pedir_turno = new System.Windows.Forms.Button();
            this.but_comprar_bonos = new System.Windows.Forms.Button();
            this.group_por_afiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_registrar_llegada
            // 
            this.but_registrar_llegada.Location = new System.Drawing.Point(82, 188);
            this.but_registrar_llegada.Name = "but_registrar_llegada";
            this.but_registrar_llegada.Size = new System.Drawing.Size(121, 23);
            this.but_registrar_llegada.TabIndex = 7;
            this.but_registrar_llegada.Text = "Registrar Llegada";
            this.but_registrar_llegada.UseVisualStyleBackColor = true;
            this.but_registrar_llegada.Click += new System.EventHandler(this.but_registrar_llegada_Click);
            // 
            // but_consultar_estadisticas
            // 
            this.but_consultar_estadisticas.Location = new System.Drawing.Point(82, 143);
            this.but_consultar_estadisticas.Name = "but_consultar_estadisticas";
            this.but_consultar_estadisticas.Size = new System.Drawing.Size(121, 23);
            this.but_consultar_estadisticas.TabIndex = 6;
            this.but_consultar_estadisticas.Text = "Consultar Estadisticas";
            this.but_consultar_estadisticas.UseVisualStyleBackColor = true;
            this.but_consultar_estadisticas.Click += new System.EventHandler(this.but_consultar_estadisticas_Click);
            // 
            // but_administrar_afiliado
            // 
            this.but_administrar_afiliado.Location = new System.Drawing.Point(82, 90);
            this.but_administrar_afiliado.Name = "but_administrar_afiliado";
            this.but_administrar_afiliado.Size = new System.Drawing.Size(121, 27);
            this.but_administrar_afiliado.TabIndex = 5;
            this.but_administrar_afiliado.Text = "Administrar Afiliados";
            this.but_administrar_afiliado.UseVisualStyleBackColor = true;
            this.but_administrar_afiliado.Click += new System.EventHandler(this.but_administrar_afiliado_Click);
            // 
            // but_administrar_rol
            // 
            this.but_administrar_rol.Location = new System.Drawing.Point(82, 37);
            this.but_administrar_rol.Name = "but_administrar_rol";
            this.but_administrar_rol.Size = new System.Drawing.Size(121, 27);
            this.but_administrar_rol.TabIndex = 4;
            this.but_administrar_rol.Text = "Administrar Roles";
            this.but_administrar_rol.UseVisualStyleBackColor = true;
            this.but_administrar_rol.Click += new System.EventHandler(this.but_administrar_rol_Click);
            // 
            // group_por_afiliado
            // 
            this.group_por_afiliado.Controls.Add(this.but_pedir_turno);
            this.group_por_afiliado.Controls.Add(this.but_comprar_bonos);
            this.group_por_afiliado.Location = new System.Drawing.Point(23, 229);
            this.group_por_afiliado.Name = "group_por_afiliado";
            this.group_por_afiliado.Size = new System.Drawing.Size(247, 98);
            this.group_por_afiliado.TabIndex = 8;
            this.group_por_afiliado.TabStop = false;
            this.group_por_afiliado.Text = "Por el afiliado";
            // 
            // but_pedir_turno
            // 
            this.but_pedir_turno.Location = new System.Drawing.Point(65, 52);
            this.but_pedir_turno.Name = "but_pedir_turno";
            this.but_pedir_turno.Size = new System.Drawing.Size(121, 27);
            this.but_pedir_turno.TabIndex = 6;
            this.but_pedir_turno.Text = "Pedir Turno";
            this.but_pedir_turno.UseVisualStyleBackColor = true;
            this.but_pedir_turno.Click += new System.EventHandler(this.but_pedir_turno_Click);
            // 
            // but_comprar_bonos
            // 
            this.but_comprar_bonos.Location = new System.Drawing.Point(65, 19);
            this.but_comprar_bonos.Name = "but_comprar_bonos";
            this.but_comprar_bonos.Size = new System.Drawing.Size(121, 27);
            this.but_comprar_bonos.TabIndex = 5;
            this.but_comprar_bonos.Text = "Comprar Bonos";
            this.but_comprar_bonos.UseVisualStyleBackColor = true;
            this.but_comprar_bonos.Click += new System.EventHandler(this.but_comprar_bonos_Click);
            // 
            // frm_tareas_administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 354);
            this.Controls.Add(this.group_por_afiliado);
            this.Controls.Add(this.but_registrar_llegada);
            this.Controls.Add(this.but_consultar_estadisticas);
            this.Controls.Add(this.but_administrar_afiliado);
            this.Controls.Add(this.but_administrar_rol);
            this.Name = "frm_tareas_administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Administrativo";
            this.group_por_afiliado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_registrar_llegada;
        private System.Windows.Forms.Button but_consultar_estadisticas;
        private System.Windows.Forms.Button but_administrar_afiliado;
        private System.Windows.Forms.Button but_administrar_rol;
        private System.Windows.Forms.GroupBox group_por_afiliado;
        private System.Windows.Forms.Button but_pedir_turno;
        private System.Windows.Forms.Button but_comprar_bonos;
    }
}