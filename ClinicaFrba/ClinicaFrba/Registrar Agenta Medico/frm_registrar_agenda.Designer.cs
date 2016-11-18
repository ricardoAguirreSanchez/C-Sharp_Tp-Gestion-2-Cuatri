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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_dias = new System.Windows.Forms.DataGridView();
            this.gb_especialidad = new System.Windows.Forms.GroupBox();
            this.dgv_especialidad = new System.Windows.Forms.DataGridView();
            this.dtp_horas_lv = new System.Windows.Forms.DateTimePicker();
            this.dtp_horas_s = new System.Windows.Forms.DateTimePicker();
            this.but_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_horario = new System.Windows.Forms.GroupBox();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dias)).BeginInit();
            this.gb_especialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidad)).BeginInit();
            this.gb_horario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_siguiente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_dias);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 303);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dias: Lunes(2),Martes(3),Miercoles(4),\r\n         Jueves(5),Viernes(6),Sabado(7)";
            // 
            // dgv_dias
            // 
            this.dgv_dias.AllowUserToAddRows = false;
            this.dgv_dias.AllowUserToDeleteRows = false;
            this.dgv_dias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir});
            this.dgv_dias.Location = new System.Drawing.Point(17, 73);
            this.dgv_dias.Name = "dgv_dias";
            this.dgv_dias.Size = new System.Drawing.Size(205, 182);
            this.dgv_dias.TabIndex = 2;
            this.dgv_dias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gb_especialidad
            // 
            this.gb_especialidad.Controls.Add(this.dgv_especialidad);
            this.gb_especialidad.Location = new System.Drawing.Point(277, 9);
            this.gb_especialidad.Name = "gb_especialidad";
            this.gb_especialidad.Size = new System.Drawing.Size(243, 303);
            this.gb_especialidad.TabIndex = 1;
            this.gb_especialidad.TabStop = false;
            this.gb_especialidad.Text = "Elegir la especialidad:";
            // 
            // dgv_especialidad
            // 
            this.dgv_especialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_especialidad.Location = new System.Drawing.Point(16, 26);
            this.dgv_especialidad.Name = "dgv_especialidad";
            this.dgv_especialidad.Size = new System.Drawing.Size(200, 229);
            this.dgv_especialidad.TabIndex = 3;
            // 
            // dtp_horas_lv
            // 
            this.dtp_horas_lv.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horas_lv.Location = new System.Drawing.Point(26, 62);
            this.dtp_horas_lv.Name = "dtp_horas_lv";
            this.dtp_horas_lv.Size = new System.Drawing.Size(203, 20);
            this.dtp_horas_lv.TabIndex = 2;
            // 
            // dtp_horas_s
            // 
            this.dtp_horas_s.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horas_s.Location = new System.Drawing.Point(26, 126);
            this.dtp_horas_s.Name = "dtp_horas_s";
            this.dtp_horas_s.Size = new System.Drawing.Size(203, 20);
            this.dtp_horas_s.TabIndex = 3;
            // 
            // but_guardar
            // 
            this.but_guardar.Location = new System.Drawing.Point(121, 268);
            this.but_guardar.Name = "but_guardar";
            this.but_guardar.Size = new System.Drawing.Size(102, 30);
            this.but_guardar.TabIndex = 4;
            this.but_guardar.Text = "Guardar";
            this.but_guardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horario para dia(s) de L - V \r\nde 07:00 a 20:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horario para dia(s) Sabados\r\nde 10:00 a 15:00";
            // 
            // gb_horario
            // 
            this.gb_horario.Controls.Add(this.label2);
            this.gb_horario.Controls.Add(this.but_guardar);
            this.gb_horario.Controls.Add(this.label3);
            this.gb_horario.Controls.Add(this.dtp_horas_s);
            this.gb_horario.Controls.Add(this.dtp_horas_lv);
            this.gb_horario.Location = new System.Drawing.Point(526, 8);
            this.gb_horario.Name = "gb_horario";
            this.gb_horario.Size = new System.Drawing.Size(235, 304);
            this.gb_horario.TabIndex = 7;
            this.gb_horario.TabStop = false;
            this.gb_horario.Text = "Horario";
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            // 
            // frm_registrar_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 330);
            this.Controls.Add(this.gb_horario);
            this.Controls.Add(this.gb_especialidad);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_registrar_agenda";
            this.Text = "Registrar Agenda";
            this.Load += new System.EventHandler(this.frm_registrar_agenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dias)).EndInit();
            this.gb_especialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidad)).EndInit();
            this.gb_horario.ResumeLayout(false);
            this.gb_horario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dias;
        private System.Windows.Forms.Button but_siguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_especialidad;
        private System.Windows.Forms.DataGridView dgv_especialidad;
        private System.Windows.Forms.DateTimePicker dtp_horas_lv;
        private System.Windows.Forms.DateTimePicker dtp_horas_s;
        private System.Windows.Forms.Button but_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_horario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
    }
}