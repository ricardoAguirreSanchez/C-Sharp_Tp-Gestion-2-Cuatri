namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class frm_registrar_agenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_siguiente = new System.Windows.Forms.Button();
            this.gb_especialidad = new System.Windows.Forms.GroupBox();
            this.dgv_especialidad = new System.Windows.Forms.DataGridView();
            this.but_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_horario = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_codigo_medico = new System.Windows.Forms.TextBox();
            this.dgv_dias = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tex_hora_lv_desde = new System.Windows.Forms.TextBox();
            this.tex_horas_lv_hasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tex_horas_s_desde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_horas_s_hasta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_especialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidad)).BeginInit();
            this.gb_horario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dias);
            this.groupBox1.Controls.Add(this.but_siguiente);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir el o los dias:";
            // 
            // but_siguiente
            // 
            this.but_siguiente.Location = new System.Drawing.Point(120, 267);
            this.but_siguiente.Name = "but_siguiente";
            this.but_siguiente.Size = new System.Drawing.Size(102, 30);
            this.but_siguiente.TabIndex = 7;
            this.but_siguiente.Text = "Siguiente";
            this.but_siguiente.UseVisualStyleBackColor = true;
            this.but_siguiente.Click += new System.EventHandler(this.but_dia_Click);
            // 
            // gb_especialidad
            // 
            this.gb_especialidad.Controls.Add(this.dgv_especialidad);
            this.gb_especialidad.Location = new System.Drawing.Point(272, 48);
            this.gb_especialidad.Name = "gb_especialidad";
            this.gb_especialidad.Size = new System.Drawing.Size(243, 303);
            this.gb_especialidad.TabIndex = 1;
            this.gb_especialidad.TabStop = false;
            this.gb_especialidad.Text = "Elegir la especialidad:";
            // 
            // dgv_especialidad
            // 
            this.dgv_especialidad.AllowUserToAddRows = false;
            this.dgv_especialidad.AllowUserToDeleteRows = false;
            this.dgv_especialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_especialidad.Location = new System.Drawing.Point(22, 25);
            this.dgv_especialidad.Name = "dgv_especialidad";
            this.dgv_especialidad.ReadOnly = true;
            this.dgv_especialidad.Size = new System.Drawing.Size(200, 229);
            this.dgv_especialidad.TabIndex = 3;
            // 
            // but_guardar
            // 
            this.but_guardar.Location = new System.Drawing.Point(126, 274);
            this.but_guardar.Name = "but_guardar";
            this.but_guardar.Size = new System.Drawing.Size(102, 30);
            this.but_guardar.TabIndex = 4;
            this.but_guardar.Text = "Guardar";
            this.but_guardar.UseVisualStyleBackColor = true;
            this.but_guardar.Click += new System.EventHandler(this.but_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horario para dia(s) de L - V \r\nde 07:00 a 20:00 cada 30 min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horario para dia(s) Sabados\r\nde 10:00 a 15:00 cada 30 min";
            // 
            // gb_horario
            // 
            this.gb_horario.Controls.Add(this.label9);
            this.gb_horario.Controls.Add(this.tex_horas_s_hasta);
            this.gb_horario.Controls.Add(this.label8);
            this.gb_horario.Controls.Add(this.tex_horas_s_desde);
            this.gb_horario.Controls.Add(this.label7);
            this.gb_horario.Controls.Add(this.label1);
            this.gb_horario.Controls.Add(this.tex_horas_lv_hasta);
            this.gb_horario.Controls.Add(this.tex_hora_lv_desde);
            this.gb_horario.Controls.Add(this.label6);
            this.gb_horario.Controls.Add(this.dtp_fecha_hasta);
            this.gb_horario.Controls.Add(this.label5);
            this.gb_horario.Controls.Add(this.dtp_fecha_desde);
            this.gb_horario.Controls.Add(this.label2);
            this.gb_horario.Controls.Add(this.but_guardar);
            this.gb_horario.Controls.Add(this.label3);
            this.gb_horario.Location = new System.Drawing.Point(526, 39);
            this.gb_horario.Name = "gb_horario";
            this.gb_horario.Size = new System.Drawing.Size(235, 312);
            this.gb_horario.TabIndex = 7;
            this.gb_horario.TabStop = false;
            this.gb_horario.Text = "Horario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Respetar rango sino no se tomara en cuenta";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(28, 246);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rango de fechas:";
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(28, 220);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_desde.TabIndex = 9;
            this.dtp_fecha_desde.Value = new System.DateTime(2016, 11, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo:";
            // 
            // tex_codigo_medico
            // 
            this.tex_codigo_medico.Location = new System.Drawing.Point(61, 15);
            this.tex_codigo_medico.Name = "tex_codigo_medico";
            this.tex_codigo_medico.Size = new System.Drawing.Size(98, 20);
            this.tex_codigo_medico.TabIndex = 9;
            // 
            // dgv_dias
            // 
            this.dgv_dias.AllowUserToAddRows = false;
            this.dgv_dias.AllowUserToDeleteRows = false;
            this.dgv_dias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgv_dias.Location = new System.Drawing.Point(17, 26);
            this.dgv_dias.Name = "dgv_dias";
            this.dgv_dias.Size = new System.Drawing.Size(205, 229);
            this.dgv_dias.TabIndex = 29;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Elegir";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tex_hora_lv_desde
            // 
            this.tex_hora_lv_desde.Location = new System.Drawing.Point(75, 65);
            this.tex_hora_lv_desde.Name = "tex_hora_lv_desde";
            this.tex_hora_lv_desde.Size = new System.Drawing.Size(68, 20);
            this.tex_hora_lv_desde.TabIndex = 10;
            // 
            // tex_horas_lv_hasta
            // 
            this.tex_horas_lv_hasta.Location = new System.Drawing.Point(75, 91);
            this.tex_horas_lv_hasta.Name = "tex_horas_lv_hasta";
            this.tex_horas_lv_hasta.Size = new System.Drawing.Size(68, 20);
            this.tex_horas_lv_hasta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasta:";
            // 
            // tex_horas_s_desde
            // 
            this.tex_horas_s_desde.Location = new System.Drawing.Point(75, 141);
            this.tex_horas_s_desde.Name = "tex_horas_s_desde";
            this.tex_horas_s_desde.Size = new System.Drawing.Size(68, 20);
            this.tex_horas_s_desde.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Desde:";
            // 
            // tex_horas_s_hasta
            // 
            this.tex_horas_s_hasta.Location = new System.Drawing.Point(75, 167);
            this.tex_horas_s_hasta.Name = "tex_horas_s_hasta";
            this.tex_horas_s_hasta.Size = new System.Drawing.Size(68, 20);
            this.tex_horas_s_hasta.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hasta:";
            // 
            // frm_registrar_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 363);
            this.Controls.Add(this.tex_codigo_medico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb_horario);
            this.Controls.Add(this.gb_especialidad);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_registrar_agenda";
            this.Text = "Registrar Agenda";
            this.Load += new System.EventHandler(this.frm_registrar_agenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_especialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidad)).EndInit();
            this.gb_horario.ResumeLayout(false);
            this.gb_horario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_siguiente;
        private System.Windows.Forms.GroupBox gb_especialidad;
        private System.Windows.Forms.DataGridView dgv_especialidad;
        private System.Windows.Forms.Button but_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_codigo_medico;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_dias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox tex_hora_lv_desde;
        private System.Windows.Forms.TextBox tex_horas_lv_hasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_horas_s_desde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tex_horas_s_hasta;
        private System.Windows.Forms.Label label9;
    }
}