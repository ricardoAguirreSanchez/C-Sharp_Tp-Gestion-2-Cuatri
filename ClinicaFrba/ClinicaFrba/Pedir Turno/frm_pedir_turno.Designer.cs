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
            this.dtp_fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.but_buscar = new System.Windows.Forms.Button();
            this.dgv_listado_turnos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.but_reservar = new System.Windows.Forms.Button();
            this.cbx_especialidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_numero_afiliado
            // 
            this.tex_numero_afiliado.Location = new System.Drawing.Point(229, 17);
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
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.Location = new System.Drawing.Point(130, 49);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_desde.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha desde:";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(130, 85);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_hasta.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha hasta:";
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(130, 159);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(74, 31);
            this.but_buscar.TabIndex = 34;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_listado_turnos
            // 
            this.dgv_listado_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_turnos.Location = new System.Drawing.Point(17, 222);
            this.dgv_listado_turnos.Name = "dgv_listado_turnos";
            this.dgv_listado_turnos.Size = new System.Drawing.Size(240, 150);
            this.dgv_listado_turnos.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Listado de turnos disponibles:";
            // 
            // but_reservar
            // 
            this.but_reservar.Location = new System.Drawing.Point(130, 385);
            this.but_reservar.Name = "but_reservar";
            this.but_reservar.Size = new System.Drawing.Size(74, 31);
            this.but_reservar.TabIndex = 38;
            this.but_reservar.Text = "Reservar turno";
            this.but_reservar.UseVisualStyleBackColor = true;
            // 
            // cbx_especialidad
            // 
            this.cbx_especialidad.FormattingEnabled = true;
            this.cbx_especialidad.Location = new System.Drawing.Point(130, 118);
            this.cbx_especialidad.Name = "cbx_especialidad";
            this.cbx_especialidad.Size = new System.Drawing.Size(199, 21);
            this.cbx_especialidad.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Especialidad:";
            // 
            // frm_pedir_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_especialidad);
            this.Controls.Add(this.but_reservar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_listado_turnos);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.dtp_fecha_hasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_fecha_desde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tex_numero_afiliado);
            this.Controls.Add(this.label1);
            this.Name = "frm_pedir_turno";
            this.Text = "Pedir turno";
            this.Load += new System.EventHandler(this.frm_pedir_turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_numero_afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_fecha_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.DataGridView dgv_listado_turnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_reservar;
        private System.Windows.Forms.ComboBox cbx_especialidad;
        private System.Windows.Forms.Label label4;
    }
}