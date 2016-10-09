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
            this.tex_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_cancelar_periodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_cancelar_dia = new System.Windows.Forms.Button();
            this.tex_detalle_cancelacion = new System.Windows.Forms.TextBox();
            this.lib_tipo_cancelacion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_usuario
            // 
            this.tex_usuario.Location = new System.Drawing.Point(104, 9);
            this.tex_usuario.Name = "tex_usuario";
            this.tex_usuario.Size = new System.Drawing.Size(100, 20);
            this.tex_usuario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // but_cancelar_periodo
            // 
            this.but_cancelar_periodo.Location = new System.Drawing.Point(152, 99);
            this.but_cancelar_periodo.Name = "but_cancelar_periodo";
            this.but_cancelar_periodo.Size = new System.Drawing.Size(75, 23);
            this.but_cancelar_periodo.TabIndex = 7;
            this.but_cancelar_periodo.Text = "Cancelar";
            this.but_cancelar_periodo.UseVisualStyleBackColor = true;
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
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(104, 31);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde.TabIndex = 13;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(106, 57);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_cancelar_periodo);
            this.groupBox1.Controls.Add(this.dtp_hasta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_desde);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 140);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancelar por Periodo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.but_cancelar_dia);
            this.groupBox2.Location = new System.Drawing.Point(15, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 206);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancelar por dia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 144);
            this.dataGridView1.TabIndex = 15;
            // 
            // but_cancelar_dia
            // 
            this.but_cancelar_dia.Location = new System.Drawing.Point(149, 177);
            this.but_cancelar_dia.Name = "but_cancelar_dia";
            this.but_cancelar_dia.Size = new System.Drawing.Size(75, 23);
            this.but_cancelar_dia.TabIndex = 7;
            this.but_cancelar_dia.Text = "Cancelar";
            this.but_cancelar_dia.UseVisualStyleBackColor = true;
            // 
            // tex_detalle_cancelacion
            // 
            this.tex_detalle_cancelacion.Location = new System.Drawing.Point(613, 45);
            this.tex_detalle_cancelacion.Multiline = true;
            this.tex_detalle_cancelacion.Name = "tex_detalle_cancelacion";
            this.tex_detalle_cancelacion.Size = new System.Drawing.Size(138, 62);
            this.tex_detalle_cancelacion.TabIndex = 21;
            // 
            // lib_tipo_cancelacion
            // 
            this.lib_tipo_cancelacion.FormattingEnabled = true;
            this.lib_tipo_cancelacion.Location = new System.Drawing.Point(583, 125);
            this.lib_tipo_cancelacion.Name = "lib_tipo_cancelacion";
            this.lib_tipo_cancelacion.Size = new System.Drawing.Size(168, 30);
            this.lib_tipo_cancelacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de cancelacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Detalle de la cancelacion:";
            // 
            // frm_cancelar_atencion_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 429);
            this.Controls.Add(this.tex_detalle_cancelacion);
            this.Controls.Add(this.lib_tipo_cancelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tex_usuario);
            this.Controls.Add(this.label2);
            this.Name = "frm_cancelar_atencion_medico";
            this.Text = "Cancelar Atencion";
            this.Load += new System.EventHandler(this.frm_cancelar_atencion_medico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_cancelar_periodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_cancelar_dia;
        private System.Windows.Forms.TextBox tex_detalle_cancelacion;
        private System.Windows.Forms.ListBox lib_tipo_cancelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}