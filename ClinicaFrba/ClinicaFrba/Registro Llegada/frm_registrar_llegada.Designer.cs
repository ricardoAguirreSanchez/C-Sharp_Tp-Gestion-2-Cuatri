namespace ClinicaFrba.AbmRol
{
    partial class frm_registrar_llegada
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
            this.com_especialidad = new System.Windows.Forms.ComboBox();
            this.but_buscar = new System.Windows.Forms.Button();
            this.dgv_turnos_del_dia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.but_registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_del_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // com_especialidad
            // 
            this.com_especialidad.FormattingEnabled = true;
            this.com_especialidad.Location = new System.Drawing.Point(138, 29);
            this.com_especialidad.Name = "com_especialidad";
            this.com_especialidad.Size = new System.Drawing.Size(121, 21);
            this.com_especialidad.TabIndex = 0;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(28, 63);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(76, 23);
            this.but_buscar.TabIndex = 1;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_turnos_del_dia
            // 
            this.dgv_turnos_del_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnos_del_dia.Location = new System.Drawing.Point(12, 101);
            this.dgv_turnos_del_dia.Name = "dgv_turnos_del_dia";
            this.dgv_turnos_del_dia.Size = new System.Drawing.Size(294, 219);
            this.dgv_turnos_del_dia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Especialidad medica:";
            // 
            // but_registrar
            // 
            this.but_registrar.Location = new System.Drawing.Point(121, 355);
            this.but_registrar.Name = "but_registrar";
            this.but_registrar.Size = new System.Drawing.Size(76, 23);
            this.but_registrar.TabIndex = 4;
            this.but_registrar.Text = "Registrar llegada";
            this.but_registrar.UseVisualStyleBackColor = true;
            // 
            // frm_registrar_llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 413);
            this.Controls.Add(this.but_registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_turnos_del_dia);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.com_especialidad);
            this.Name = "frm_registrar_llegada";
            this.Text = "Registrar Llegada";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_del_dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_especialidad;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.DataGridView dgv_turnos_del_dia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_registrar;
    }
}