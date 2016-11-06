namespace ClinicaFrba.Cancelar_Atencion
{
    partial class frm_cancelar_atencion_afiliado
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
            this.dgv_listado_turnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.but_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_num_afiliado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_detalle_cancelacion = new System.Windows.Forms.TextBox();
            this.dgv_tipo_cancelacion = new System.Windows.Forms.DataGridView();
            this.but_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_cancelacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listado_turnos
            // 
            this.dgv_listado_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_turnos.Location = new System.Drawing.Point(12, 62);
            this.dgv_listado_turnos.Name = "dgv_listado_turnos";
            this.dgv_listado_turnos.Size = new System.Drawing.Size(241, 144);
            this.dgv_listado_turnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turnos que puede cancelar:";
            // 
            // but_cancelar
            // 
            this.but_cancelar.Location = new System.Drawing.Point(469, 261);
            this.but_cancelar.Name = "but_cancelar";
            this.but_cancelar.Size = new System.Drawing.Size(75, 23);
            this.but_cancelar.TabIndex = 2;
            this.but_cancelar.Text = "Cancelar";
            this.but_cancelar.UseVisualStyleBackColor = true;
            this.but_cancelar.Click += new System.EventHandler(this.but_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de afiliado:";
            // 
            // tex_num_afiliado
            // 
            this.tex_num_afiliado.Location = new System.Drawing.Point(118, 22);
            this.tex_num_afiliado.Name = "tex_num_afiliado";
            this.tex_num_afiliado.Size = new System.Drawing.Size(100, 20);
            this.tex_num_afiliado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle de la cancelacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de cancelacion:";
            // 
            // tex_detalle_cancelacion
            // 
            this.tex_detalle_cancelacion.Location = new System.Drawing.Point(438, 53);
            this.tex_detalle_cancelacion.Multiline = true;
            this.tex_detalle_cancelacion.Name = "tex_detalle_cancelacion";
            this.tex_detalle_cancelacion.Size = new System.Drawing.Size(138, 62);
            this.tex_detalle_cancelacion.TabIndex = 8;
            // 
            // dgv_tipo_cancelacion
            // 
            this.dgv_tipo_cancelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipo_cancelacion.Location = new System.Drawing.Point(438, 130);
            this.dgv_tipo_cancelacion.Name = "dgv_tipo_cancelacion";
            this.dgv_tipo_cancelacion.Size = new System.Drawing.Size(138, 105);
            this.dgv_tipo_cancelacion.TabIndex = 25;
            // 
            // but_buscar
            // 
            this.but_buscar.Location = new System.Drawing.Point(224, 22);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(75, 23);
            this.but_buscar.TabIndex = 26;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            this.but_buscar.Click += new System.EventHandler(this.but_buscar_Click);
            // 
            // frm_cancelar_atencion_afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 314);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.dgv_tipo_cancelacion);
            this.Controls.Add(this.tex_detalle_cancelacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tex_num_afiliado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_listado_turnos);
            this.Name = "frm_cancelar_atencion_afiliado";
            this.Text = "Cancelar Atencion";
            this.Load += new System.EventHandler(this.frm_cancelar_atencion_afiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_turnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_cancelacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listado_turnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_num_afiliado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_detalle_cancelacion;
        private System.Windows.Forms.DataGridView dgv_tipo_cancelacion;
        private System.Windows.Forms.Button but_buscar;
    }
}