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
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.but_buscar = new System.Windows.Forms.Button();
            this.dgv_listado_turnos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.but_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_numero_afiliado
            // 
            this.tex_numero_afiliado.Location = new System.Drawing.Point(110, 17);
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
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(130, 49);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_nacimiento.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(130, 125);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(74, 31);
            this.but_buscar.TabIndex = 34;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_listado_turnos
            // 
            this.dgv_listado_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_turnos.Location = new System.Drawing.Point(17, 188);
            this.dgv_listado_turnos.Name = "dgv_listado_turnos";
            this.dgv_listado_turnos.Size = new System.Drawing.Size(240, 150);
            this.dgv_listado_turnos.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Listado de turnos disponibles:";
            // 
            // but_aceptar
            // 
            this.but_aceptar.Location = new System.Drawing.Point(130, 351);
            this.but_aceptar.Name = "but_aceptar";
            this.but_aceptar.Size = new System.Drawing.Size(74, 31);
            this.but_aceptar.TabIndex = 38;
            this.but_aceptar.Text = "Aceptar";
            this.but_aceptar.UseVisualStyleBackColor = true;
            // 
            // frm_pedir_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 394);
            this.Controls.Add(this.but_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_listado_turnos);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tex_numero_afiliado);
            this.Controls.Add(this.label1);
            this.Name = "frm_pedir_turno";
            this.Text = "Pedir turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_numero_afiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.DataGridView dgv_listado_turnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_aceptar;
    }
}