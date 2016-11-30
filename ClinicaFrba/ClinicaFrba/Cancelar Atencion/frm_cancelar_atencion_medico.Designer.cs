namespace ClinicaFrba.Cancelar_Atencion
{
    partial class frm_cancelar_atencion_medico
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
            this.tex_codigo_medico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_cancelar_periodo = new System.Windows.Forms.GroupBox();
            this.rb_cancelar_periodo = new System.Windows.Forms.RadioButton();
            this.gb_cancelar_dia = new System.Windows.Forms.GroupBox();
            this.dgv_cancelar_dia = new System.Windows.Forms.DataGridView();
            this.rb_cancelar_dia = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tex_detalle_cancelacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_tipo_cancelacion = new System.Windows.Forms.DataGridView();
            this.but_Buscar_dias = new System.Windows.Forms.Button();
            this.tex_desde = new System.Windows.Forms.TextBox();
            this.tex_hasta = new System.Windows.Forms.TextBox();
            this.gb_cancelar_periodo.SuspendLayout();
            this.gb_cancelar_dia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cancelar_dia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_cancelacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_codigo_medico
            // 
            this.tex_codigo_medico.Location = new System.Drawing.Point(70, 12);
            this.tex_codigo_medico.Name = "tex_codigo_medico";
            this.tex_codigo_medico.Size = new System.Drawing.Size(100, 20);
            this.tex_codigo_medico.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // but_cancelar
            // 
            this.but_cancelar.Location = new System.Drawing.Point(519, 300);
            this.but_cancelar.Name = "but_cancelar";
            this.but_cancelar.Size = new System.Drawing.Size(75, 23);
            this.but_cancelar.TabIndex = 7;
            this.but_cancelar.Text = "Cancelar";
            this.but_cancelar.UseVisualStyleBackColor = true;
            this.but_cancelar.Click += new System.EventHandler(this.but_cancelar_periodo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hasta:";
            // 
            // gb_cancelar_periodo
            // 
            this.gb_cancelar_periodo.Controls.Add(this.tex_hasta);
            this.gb_cancelar_periodo.Controls.Add(this.tex_desde);
            this.gb_cancelar_periodo.Controls.Add(this.rb_cancelar_periodo);
            this.gb_cancelar_periodo.Controls.Add(this.label4);
            this.gb_cancelar_periodo.Controls.Add(this.label5);
            this.gb_cancelar_periodo.Location = new System.Drawing.Point(12, 253);
            this.gb_cancelar_periodo.Name = "gb_cancelar_periodo";
            this.gb_cancelar_periodo.Size = new System.Drawing.Size(362, 104);
            this.gb_cancelar_periodo.TabIndex = 16;
            this.gb_cancelar_periodo.TabStop = false;
            // 
            // rb_cancelar_periodo
            // 
            this.rb_cancelar_periodo.AutoSize = true;
            this.rb_cancelar_periodo.Location = new System.Drawing.Point(28, 81);
            this.rb_cancelar_periodo.Name = "rb_cancelar_periodo";
            this.rb_cancelar_periodo.Size = new System.Drawing.Size(170, 17);
            this.rb_cancelar_periodo.TabIndex = 22;
            this.rb_cancelar_periodo.TabStop = true;
            this.rb_cancelar_periodo.Text = "Cancelar por Periodo de Horas";
            this.rb_cancelar_periodo.UseVisualStyleBackColor = true;
            this.rb_cancelar_periodo.CheckedChanged += new System.EventHandler(this.rb_cancelar_periodo_CheckedChanged);
            // 
            // gb_cancelar_dia
            // 
            this.gb_cancelar_dia.Controls.Add(this.dgv_cancelar_dia);
            this.gb_cancelar_dia.Controls.Add(this.rb_cancelar_dia);
            this.gb_cancelar_dia.Controls.Add(this.dataGridView1);
            this.gb_cancelar_dia.Location = new System.Drawing.Point(12, 45);
            this.gb_cancelar_dia.Name = "gb_cancelar_dia";
            this.gb_cancelar_dia.Size = new System.Drawing.Size(362, 192);
            this.gb_cancelar_dia.TabIndex = 17;
            this.gb_cancelar_dia.TabStop = false;
            this.gb_cancelar_dia.Text = "Elija un dia:";
            // 
            // dgv_cancelar_dia
            // 
            this.dgv_cancelar_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cancelar_dia.Location = new System.Drawing.Point(28, 19);
            this.dgv_cancelar_dia.Name = "dgv_cancelar_dia";
            this.dgv_cancelar_dia.Size = new System.Drawing.Size(305, 130);
            this.dgv_cancelar_dia.TabIndex = 16;
            this.dgv_cancelar_dia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cancelar_dia_CellContentClick);
            // 
            // rb_cancelar_dia
            // 
            this.rb_cancelar_dia.AutoSize = true;
            this.rb_cancelar_dia.Location = new System.Drawing.Point(28, 155);
            this.rb_cancelar_dia.Name = "rb_cancelar_dia";
            this.rb_cancelar_dia.Size = new System.Drawing.Size(102, 17);
            this.rb_cancelar_dia.TabIndex = 23;
            this.rb_cancelar_dia.TabStop = true;
            this.rb_cancelar_dia.Text = "Cancelar por dia";
            this.rb_cancelar_dia.UseVisualStyleBackColor = true;
            this.rb_cancelar_dia.CheckedChanged += new System.EventHandler(this.rb_cancelar_dia_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 130);
            this.dataGridView1.TabIndex = 15;
            // 
            // tex_detalle_cancelacion
            // 
            this.tex_detalle_cancelacion.Location = new System.Drawing.Point(538, 45);
            this.tex_detalle_cancelacion.Multiline = true;
            this.tex_detalle_cancelacion.Name = "tex_detalle_cancelacion";
            this.tex_detalle_cancelacion.Size = new System.Drawing.Size(138, 62);
            this.tex_detalle_cancelacion.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de cancelacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Detalle de la cancelacion:";
            // 
            // dgv_tipo_cancelacion
            // 
            this.dgv_tipo_cancelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipo_cancelacion.Location = new System.Drawing.Point(538, 124);
            this.dgv_tipo_cancelacion.Name = "dgv_tipo_cancelacion";
            this.dgv_tipo_cancelacion.Size = new System.Drawing.Size(116, 130);
            this.dgv_tipo_cancelacion.TabIndex = 24;
            // 
            // but_Buscar_dias
            // 
            this.but_Buscar_dias.Location = new System.Drawing.Point(176, 12);
            this.but_Buscar_dias.Name = "but_Buscar_dias";
            this.but_Buscar_dias.Size = new System.Drawing.Size(88, 25);
            this.but_Buscar_dias.TabIndex = 25;
            this.but_Buscar_dias.Text = "Buscar Dias";
            this.but_Buscar_dias.UseVisualStyleBackColor = true;
            this.but_Buscar_dias.Click += new System.EventHandler(this.button1_Click);
            // 
            // tex_desde
            // 
            this.tex_desde.Location = new System.Drawing.Point(106, 31);
            this.tex_desde.Name = "tex_desde";
            this.tex_desde.Size = new System.Drawing.Size(100, 20);
            this.tex_desde.TabIndex = 26;
            // 
            // tex_hasta
            // 
            this.tex_hasta.Location = new System.Drawing.Point(106, 57);
            this.tex_hasta.Name = "tex_hasta";
            this.tex_hasta.Size = new System.Drawing.Size(100, 20);
            this.tex_hasta.TabIndex = 27;
            // 
            // frm_cancelar_atencion_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 429);
            this.Controls.Add(this.but_Buscar_dias);
            this.Controls.Add(this.dgv_tipo_cancelacion);
            this.Controls.Add(this.but_cancelar);
            this.Controls.Add(this.tex_detalle_cancelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_cancelar_dia);
            this.Controls.Add(this.gb_cancelar_periodo);
            this.Controls.Add(this.tex_codigo_medico);
            this.Controls.Add(this.label2);
            this.Name = "frm_cancelar_atencion_medico";
            this.Text = "Cancelar Atencion";
            this.Load += new System.EventHandler(this.frm_cancelar_atencion_medico_Load);
            this.gb_cancelar_periodo.ResumeLayout(false);
            this.gb_cancelar_periodo.PerformLayout();
            this.gb_cancelar_dia.ResumeLayout(false);
            this.gb_cancelar_dia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cancelar_dia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_cancelacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_codigo_medico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_cancelar_periodo;
        private System.Windows.Forms.GroupBox gb_cancelar_dia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tex_detalle_cancelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_cancelar_periodo;
        private System.Windows.Forms.RadioButton rb_cancelar_dia;
        private System.Windows.Forms.DataGridView dgv_cancelar_dia;
        private System.Windows.Forms.DataGridView dgv_tipo_cancelacion;
        private System.Windows.Forms.Button but_Buscar_dias;
        private System.Windows.Forms.TextBox tex_desde;
        private System.Windows.Forms.TextBox tex_hasta;
    }
}