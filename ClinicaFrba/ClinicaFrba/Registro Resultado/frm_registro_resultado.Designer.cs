namespace ClinicaFrba.Registro_Resultado
{
    partial class frm_registro_resultado
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
            this.but_registrar = new System.Windows.Forms.Button();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.tex_diagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_sintomas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_listado_consultas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_codigo_medico = new System.Windows.Forms.TextBox();
            this.but_buscar_consultas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // but_registrar
            // 
            this.but_registrar.Location = new System.Drawing.Point(444, 232);
            this.but_registrar.Name = "but_registrar";
            this.but_registrar.Size = new System.Drawing.Size(75, 23);
            this.but_registrar.TabIndex = 0;
            this.but_registrar.Text = "Registrar";
            this.but_registrar.UseVisualStyleBackColor = true;
            this.but_registrar.Click += new System.EventHandler(this.but_registrar_Click);
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Location = new System.Drawing.Point(357, 32);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(34, 17);
            this.rb_si.TabIndex = 12;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "Si";
            this.rb_si.UseVisualStyleBackColor = true;
            this.rb_si.CheckedChanged += new System.EventHandler(this.rb_si_CheckedChanged);
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(511, 32);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(39, 17);
            this.rb_no.TabIndex = 13;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // tex_diagnostico
            // 
            this.tex_diagnostico.Location = new System.Drawing.Point(459, 127);
            this.tex_diagnostico.Multiline = true;
            this.tex_diagnostico.Name = "tex_diagnostico";
            this.tex_diagnostico.Size = new System.Drawing.Size(156, 82);
            this.tex_diagnostico.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Detalle de diagnostico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asistencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Detalle de sintomas:";
            // 
            // tex_sintomas
            // 
            this.tex_sintomas.Location = new System.Drawing.Point(459, 67);
            this.tex_sintomas.Multiline = true;
            this.tex_sintomas.Name = "tex_sintomas";
            this.tex_sintomas.Size = new System.Drawing.Size(156, 54);
            this.tex_sintomas.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Consultas del dia:";
            // 
            // dgv_listado_consultas
            // 
            this.dgv_listado_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_consultas.Location = new System.Drawing.Point(15, 90);
            this.dgv_listado_consultas.Name = "dgv_listado_consultas";
            this.dgv_listado_consultas.Size = new System.Drawing.Size(250, 170);
            this.dgv_listado_consultas.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Codigo:";
            // 
            // tex_codigo_medico
            // 
            this.tex_codigo_medico.Location = new System.Drawing.Point(61, 32);
            this.tex_codigo_medico.Name = "tex_codigo_medico";
            this.tex_codigo_medico.Size = new System.Drawing.Size(96, 20);
            this.tex_codigo_medico.TabIndex = 23;
            // 
            // but_buscar_consultas
            // 
            this.but_buscar_consultas.Location = new System.Drawing.Point(163, 32);
            this.but_buscar_consultas.Name = "but_buscar_consultas";
            this.but_buscar_consultas.Size = new System.Drawing.Size(102, 23);
            this.but_buscar_consultas.TabIndex = 24;
            this.but_buscar_consultas.Text = "Buscar Consultas";
            this.but_buscar_consultas.UseVisualStyleBackColor = true;
            this.but_buscar_consultas.Click += new System.EventHandler(this.but_buscar_consultas_Click);
            // 
            // frm_registro_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 304);
            this.Controls.Add(this.but_buscar_consultas);
            this.Controls.Add(this.tex_codigo_medico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_listado_consultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tex_sintomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tex_diagnostico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.rb_si);
            this.Controls.Add(this.but_registrar);
            this.Name = "frm_registro_resultado";
            this.Text = "Registrar Resultado";
            this.Load += new System.EventHandler(this.frm_registro_resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_consultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_registrar;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.TextBox tex_diagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_sintomas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_listado_consultas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_codigo_medico;
        private System.Windows.Forms.Button but_buscar_consultas;
    }
}