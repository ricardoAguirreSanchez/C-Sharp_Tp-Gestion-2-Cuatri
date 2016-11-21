namespace ClinicaFrba.Pedir_Turno
{
    partial class frm_pedir_turno
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
            this.tex_numero_afiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_listado_horarios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.but_reservar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_aceptar_medico = new System.Windows.Forms.Button();
            this.but_buscar_medicos = new System.Windows.Forms.Button();
            this.dgv_especialidades = new System.Windows.Forms.DataGridView();
            this.dgv_listado_medicos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.but_mostrar_horario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_horarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_numero_afiliado
            // 
            this.tex_numero_afiliado.Location = new System.Drawing.Point(131, 20);
            this.tex_numero_afiliado.Name = "tex_numero_afiliado";
            this.tex_numero_afiliado.Size = new System.Drawing.Size(100, 20);
            this.tex_numero_afiliado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de afiliado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha desde:";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(438, 36);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha hasta:";
            // 
            // dgv_listado_horarios
            // 
            this.dgv_listado_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_horarios.Location = new System.Drawing.Point(325, 110);
            this.dgv_listado_horarios.Name = "dgv_listado_horarios";
            this.dgv_listado_horarios.Size = new System.Drawing.Size(331, 224);
            this.dgv_listado_horarios.TabIndex = 36;
            this.dgv_listado_horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_turnos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Listado de horarios disponibles";
            // 
            // but_reservar
            // 
            this.but_reservar.Location = new System.Drawing.Point(582, 340);
            this.but_reservar.Name = "but_reservar";
            this.but_reservar.Size = new System.Drawing.Size(74, 22);
            this.but_reservar.TabIndex = 38;
            this.but_reservar.Text = "Reservar turno";
            this.but_reservar.UseVisualStyleBackColor = true;
            this.but_reservar.Click += new System.EventHandler(this.but_reservar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_aceptar_medico);
            this.groupBox1.Controls.Add(this.but_buscar_medicos);
            this.groupBox1.Controls.Add(this.dgv_especialidades);
            this.groupBox1.Controls.Add(this.dgv_listado_medicos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 320);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar medico";
            // 
            // but_aceptar_medico
            // 
            this.but_aceptar_medico.Location = new System.Drawing.Point(154, 291);
            this.but_aceptar_medico.Name = "but_aceptar_medico";
            this.but_aceptar_medico.Size = new System.Drawing.Size(105, 23);
            this.but_aceptar_medico.TabIndex = 14;
            this.but_aceptar_medico.Text = "Aceptar Medico";
            this.but_aceptar_medico.UseVisualStyleBackColor = true;
            this.but_aceptar_medico.Click += new System.EventHandler(this.but_aceptar_medico_Click);
            // 
            // but_buscar_medicos
            // 
            this.but_buscar_medicos.Location = new System.Drawing.Point(154, 151);
            this.but_buscar_medicos.Name = "but_buscar_medicos";
            this.but_buscar_medicos.Size = new System.Drawing.Size(105, 23);
            this.but_buscar_medicos.TabIndex = 13;
            this.but_buscar_medicos.Text = "Buscar Medicos";
            this.but_buscar_medicos.UseVisualStyleBackColor = true;
            this.but_buscar_medicos.Click += new System.EventHandler(this.but_buscar_medicos_Click);
            // 
            // dgv_especialidades
            // 
            this.dgv_especialidades.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_especialidades.AllowUserToAddRows = false;
            this.dgv_especialidades.AllowUserToDeleteRows = false;
            this.dgv_especialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_especialidades.Location = new System.Drawing.Point(6, 53);
            this.dgv_especialidades.Name = "dgv_especialidades";
            this.dgv_especialidades.ReadOnly = true;
            this.dgv_especialidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_especialidades.Size = new System.Drawing.Size(253, 92);
            this.dgv_especialidades.TabIndex = 12;
            // 
            // dgv_listado_medicos
            // 
            this.dgv_listado_medicos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_listado_medicos.AllowUserToAddRows = false;
            this.dgv_listado_medicos.AllowUserToDeleteRows = false;
            this.dgv_listado_medicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listado_medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_medicos.Location = new System.Drawing.Point(9, 186);
            this.dgv_listado_medicos.Name = "dgv_listado_medicos";
            this.dgv_listado_medicos.ReadOnly = true;
            this.dgv_listado_medicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_listado_medicos.Size = new System.Drawing.Size(250, 92);
            this.dgv_listado_medicos.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Listado de medicos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Especialidad medica:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ACTUAL";
            // 
            // but_mostrar_horario
            // 
            this.but_mostrar_horario.Location = new System.Drawing.Point(543, 62);
            this.but_mostrar_horario.Name = "but_mostrar_horario";
            this.but_mostrar_horario.Size = new System.Drawing.Size(95, 24);
            this.but_mostrar_horario.TabIndex = 41;
            this.but_mostrar_horario.Text = "Mostrar Horarios";
            this.but_mostrar_horario.UseVisualStyleBackColor = true;
            this.but_mostrar_horario.Click += new System.EventHandler(this.but_mostrar_horario_Click);
            // 
            // frm_pedir_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.but_mostrar_horario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_reservar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_listado_horarios);
            this.Controls.Add(this.dtp_fecha_hasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tex_numero_afiliado);
            this.Controls.Add(this.label1);
            this.Name = "frm_pedir_turno";
            this.Text = "Pedir turno";
            this.Load += new System.EventHandler(this.frm_pedir_turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_horarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_numero_afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_listado_horarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_reservar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_aceptar_medico;
        private System.Windows.Forms.Button but_buscar_medicos;
        private System.Windows.Forms.DataGridView dgv_especialidades;
        private System.Windows.Forms.DataGridView dgv_listado_medicos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_mostrar_horario;
    }
}