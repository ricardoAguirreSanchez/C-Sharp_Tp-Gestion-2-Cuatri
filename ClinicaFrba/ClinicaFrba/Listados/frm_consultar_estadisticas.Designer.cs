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
            this.dtp_fecha_buscada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.com_consultar_por = new System.Windows.Forms.ComboBox();
            this.dgv_top = new System.Windows.Forms.DataGridView();
            this.but_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese fecha buscada:";
            // 
            // dtp_fecha_buscada
            // 
            this.dtp_fecha_buscada.Location = new System.Drawing.Point(148, 9);
            this.dtp_fecha_buscada.Name = "dtp_fecha_buscada";
            this.dtp_fecha_buscada.Size = new System.Drawing.Size(166, 20);
            this.dtp_fecha_buscada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // com_consultar_por
            // 
            this.com_consultar_por.FormattingEnabled = true;
            this.com_consultar_por.Location = new System.Drawing.Point(90, 40);
            this.com_consultar_por.Name = "com_consultar_por";
            this.com_consultar_por.Size = new System.Drawing.Size(236, 21);
            this.com_consultar_por.TabIndex = 3;
            // 
            // dgv_top
            // 
            this.dgv_top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_top.Location = new System.Drawing.Point(12, 100);
            this.dgv_top.Name = "dgv_top";
            this.dgv_top.Size = new System.Drawing.Size(240, 150);
            this.dgv_top.TabIndex = 4;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(15, 72);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(87, 22);
            this.but_buscar.TabIndex = 5;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            // 
            // frm_consultar_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.dgv_top);
            this.Controls.Add(this.com_consultar_por);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_fecha_buscada);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultar_estadisticas";
            this.Text = "Consultar Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_buscada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_consultar_por;
        private System.Windows.Forms.DataGridView dgv_top;
        private System.Windows.Forms.Button but_buscar;
    }
}