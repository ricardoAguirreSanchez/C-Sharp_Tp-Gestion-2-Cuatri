namespace ClinicaFrba.AbmRol
{
    partial class frm_consultar_estadisticas
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_listado_estadistico = new System.Windows.Forms.DataGridView();
            this.but_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_anio = new System.Windows.Forms.TextBox();
            this.tex_semestre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_especialidades_mas_canceladas = new System.Windows.Forms.RadioButton();
            this.rb_profesional_menos_horas_trabajadas = new System.Windows.Forms.RadioButton();
            this.rb_especilidades_mas_bono_consulta_usados = new System.Windows.Forms.RadioButton();
            this.rb_afiliado_mayor_cantidad_bono_comprados = new System.Windows.Forms.RadioButton();
            this.rb_profesionales_mas_consultados = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_cod_especialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tex_cod_plan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_estadistico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero de semestre buscado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_listado_estadistico
            // 
            this.dgv_listado_estadistico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_estadistico.Location = new System.Drawing.Point(328, 42);
            this.dgv_listado_estadistico.Name = "dgv_listado_estadistico";
            this.dgv_listado_estadistico.Size = new System.Drawing.Size(265, 250);
            this.dgv_listado_estadistico.TabIndex = 4;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(91, 297);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(87, 22);
            this.but_buscar.TabIndex = 5;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            this.but_buscar.Click += new System.EventHandler(this.but_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese año: ";
            // 
            // tex_anio
            // 
            this.tex_anio.Location = new System.Drawing.Point(170, 29);
            this.tex_anio.Name = "tex_anio";
            this.tex_anio.Size = new System.Drawing.Size(63, 20);
            this.tex_anio.TabIndex = 7;
            // 
            // tex_semestre
            // 
            this.tex_semestre.Location = new System.Drawing.Point(202, 55);
            this.tex_semestre.Name = "tex_semestre";
            this.tex_semestre.Size = new System.Drawing.Size(30, 20);
            this.tex_semestre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Primer semestre(1) Segundo semestre (2))";
            // 
            // rb_especialidades_mas_canceladas
            // 
            this.rb_especialidades_mas_canceladas.AutoSize = true;
            this.rb_especialidades_mas_canceladas.Location = new System.Drawing.Point(15, 133);
            this.rb_especialidades_mas_canceladas.Name = "rb_especialidades_mas_canceladas";
            this.rb_especialidades_mas_canceladas.Size = new System.Drawing.Size(263, 17);
            this.rb_especialidades_mas_canceladas.TabIndex = 10;
            this.rb_especialidades_mas_canceladas.TabStop = true;
            this.rb_especialidades_mas_canceladas.Text = "Especialidades que mas se registraron canceladas";
            this.rb_especialidades_mas_canceladas.UseVisualStyleBackColor = true;
            // 
            // rb_profesional_menos_horas_trabajadas
            // 
            this.rb_profesional_menos_horas_trabajadas.AutoSize = true;
            this.rb_profesional_menos_horas_trabajadas.Location = new System.Drawing.Point(15, 226);
            this.rb_profesional_menos_horas_trabajadas.Name = "rb_profesional_menos_horas_trabajadas";
            this.rb_profesional_menos_horas_trabajadas.Size = new System.Drawing.Size(218, 17);
            this.rb_profesional_menos_horas_trabajadas.TabIndex = 11;
            this.rb_profesional_menos_horas_trabajadas.TabStop = true;
            this.rb_profesional_menos_horas_trabajadas.Text = "Profesinales con menos horas trabajadas";
            this.rb_profesional_menos_horas_trabajadas.UseVisualStyleBackColor = true;
            this.rb_profesional_menos_horas_trabajadas.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_especilidades_mas_bono_consulta_usados
            // 
            this.rb_especilidades_mas_bono_consulta_usados.AutoSize = true;
            this.rb_especilidades_mas_bono_consulta_usados.Location = new System.Drawing.Point(15, 180);
            this.rb_especilidades_mas_bono_consulta_usados.Name = "rb_especilidades_mas_bono_consulta_usados";
            this.rb_especilidades_mas_bono_consulta_usados.Size = new System.Drawing.Size(275, 17);
            this.rb_especilidades_mas_bono_consulta_usados.TabIndex = 12;
            this.rb_especilidades_mas_bono_consulta_usados.TabStop = true;
            this.rb_especilidades_mas_bono_consulta_usados.Text = "Especialidades con mas bonos de consulta utilizados";
            this.rb_especilidades_mas_bono_consulta_usados.UseVisualStyleBackColor = true;
            // 
            // rb_afiliado_mayor_cantidad_bono_comprados
            // 
            this.rb_afiliado_mayor_cantidad_bono_comprados.AutoSize = true;
            this.rb_afiliado_mayor_cantidad_bono_comprados.Location = new System.Drawing.Point(15, 203);
            this.rb_afiliado_mayor_cantidad_bono_comprados.Name = "rb_afiliado_mayor_cantidad_bono_comprados";
            this.rb_afiliado_mayor_cantidad_bono_comprados.Size = new System.Drawing.Size(262, 17);
            this.rb_afiliado_mayor_cantidad_bono_comprados.TabIndex = 13;
            this.rb_afiliado_mayor_cantidad_bono_comprados.TabStop = true;
            this.rb_afiliado_mayor_cantidad_bono_comprados.Text = "Afiliados con mayor cantidad de bonos comprados";
            this.rb_afiliado_mayor_cantidad_bono_comprados.UseVisualStyleBackColor = true;
            // 
            // rb_profesionales_mas_consultados
            // 
            this.rb_profesionales_mas_consultados.AutoSize = true;
            this.rb_profesionales_mas_consultados.Location = new System.Drawing.Point(15, 157);
            this.rb_profesionales_mas_consultados.Name = "rb_profesionales_mas_consultados";
            this.rb_profesionales_mas_consultados.Size = new System.Drawing.Size(211, 17);
            this.rb_profesionales_mas_consultados.TabIndex = 14;
            this.rb_profesionales_mas_consultados.TabStop = true;
            this.rb_profesionales_mas_consultados.Text = "Profesionales mas consultados por plan";
            this.rb_profesionales_mas_consultados.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Listado Estadistico:";
            // 
            // tex_cod_especialidad
            // 
            this.tex_cod_especialidad.Location = new System.Drawing.Point(184, 243);
            this.tex_cod_especialidad.Name = "tex_cod_especialidad";
            this.tex_cod_especialidad.Size = new System.Drawing.Size(81, 20);
            this.tex_cod_especialidad.TabIndex = 17;
            this.tex_cod_especialidad.TextChanged += new System.EventHandler(this.tex_cod_especialidad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "- Codigo de especialidad:";
            // 
            // tex_cod_plan
            // 
            this.tex_cod_plan.Location = new System.Drawing.Point(184, 259);
            this.tex_cod_plan.Name = "tex_cod_plan";
            this.tex_cod_plan.Size = new System.Drawing.Size(81, 20);
            this.tex_cod_plan.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "- Codigo de plan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "(Ej. 1998)";
            // 
            // frm_consultar_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 331);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tex_cod_plan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tex_cod_especialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb_profesionales_mas_consultados);
            this.Controls.Add(this.rb_afiliado_mayor_cantidad_bono_comprados);
            this.Controls.Add(this.rb_especilidades_mas_bono_consulta_usados);
            this.Controls.Add(this.rb_profesional_menos_horas_trabajadas);
            this.Controls.Add(this.rb_especialidades_mas_canceladas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tex_semestre);
            this.Controls.Add(this.tex_anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.dgv_listado_estadistico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultar_estadisticas";
            this.Text = "Consultar Estadisticas";
            this.Load += new System.EventHandler(this.frm_consultar_estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_estadistico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_listado_estadistico;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_anio;
        private System.Windows.Forms.TextBox tex_semestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_especialidades_mas_canceladas;
        private System.Windows.Forms.RadioButton rb_profesional_menos_horas_trabajadas;
        private System.Windows.Forms.RadioButton rb_especilidades_mas_bono_consulta_usados;
        private System.Windows.Forms.RadioButton rb_afiliado_mayor_cantidad_bono_comprados;
        private System.Windows.Forms.RadioButton rb_profesionales_mas_consultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_cod_especialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tex_cod_plan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}