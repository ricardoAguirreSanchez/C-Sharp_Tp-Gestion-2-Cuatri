namespace ClinicaFrba.Registrar_Usuario
{
    partial class frm_registrar_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.tex_codigo = new System.Windows.Forms.TextBox();
            this.but_buscar = new System.Windows.Forms.Button();
            this.but_registrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_usuario = new System.Windows.Forms.TextBox();
            this.tex_contraseña = new System.Windows.Forms.TextBox();
            this.rb_medico = new System.Windows.Forms.RadioButton();
            this.rb_paciente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tex_codigo
            // 
            this.tex_codigo.Location = new System.Drawing.Point(59, 52);
            this.tex_codigo.Name = "tex_codigo";
            this.tex_codigo.Size = new System.Drawing.Size(78, 20);
            this.tex_codigo.TabIndex = 1;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(143, 52);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(66, 28);
            this.but_buscar.TabIndex = 2;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            this.but_buscar.Click += new System.EventHandler(this.but_buscar_Click);
            // 
            // but_registrar
            // 
            this.but_registrar.Location = new System.Drawing.Point(87, 183);
            this.but_registrar.Name = "but_registrar";
            this.but_registrar.Size = new System.Drawing.Size(70, 34);
            this.but_registrar.TabIndex = 3;
            this.but_registrar.Text = "Registrar";
            this.but_registrar.UseVisualStyleBackColor = true;
            this.but_registrar.Click += new System.EventHandler(this.but_registrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // tex_usuario
            // 
            this.tex_usuario.Location = new System.Drawing.Point(78, 104);
            this.tex_usuario.Name = "tex_usuario";
            this.tex_usuario.Size = new System.Drawing.Size(131, 20);
            this.tex_usuario.TabIndex = 6;
            // 
            // tex_contraseña
            // 
            this.tex_contraseña.Location = new System.Drawing.Point(78, 134);
            this.tex_contraseña.Name = "tex_contraseña";
            this.tex_contraseña.Size = new System.Drawing.Size(131, 20);
            this.tex_contraseña.TabIndex = 7;
            // 
            // rb_medico
            // 
            this.rb_medico.AutoSize = true;
            this.rb_medico.Location = new System.Drawing.Point(17, 20);
            this.rb_medico.Name = "rb_medico";
            this.rb_medico.Size = new System.Drawing.Size(60, 17);
            this.rb_medico.TabIndex = 8;
            this.rb_medico.TabStop = true;
            this.rb_medico.Text = "Medico";
            this.rb_medico.UseVisualStyleBackColor = true;
            // 
            // rb_paciente
            // 
            this.rb_paciente.AutoSize = true;
            this.rb_paciente.Location = new System.Drawing.Point(126, 19);
            this.rb_paciente.Name = "rb_paciente";
            this.rb_paciente.Size = new System.Drawing.Size(67, 17);
            this.rb_paciente.TabIndex = 9;
            this.rb_paciente.TabStop = true;
            this.rb_paciente.Text = "Paciente";
            this.rb_paciente.UseVisualStyleBackColor = true;
            // 
            // frm_registrar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 263);
            this.Controls.Add(this.rb_paciente);
            this.Controls.Add(this.rb_medico);
            this.Controls.Add(this.tex_contraseña);
            this.Controls.Add(this.tex_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_registrar);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.tex_codigo);
            this.Controls.Add(this.label1);
            this.Name = "frm_registrar_usuario";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.frm_registrar_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_codigo;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.Button but_registrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_usuario;
        private System.Windows.Forms.TextBox tex_contraseña;
        private System.Windows.Forms.RadioButton rb_medico;
        private System.Windows.Forms.RadioButton rb_paciente;
    }
}