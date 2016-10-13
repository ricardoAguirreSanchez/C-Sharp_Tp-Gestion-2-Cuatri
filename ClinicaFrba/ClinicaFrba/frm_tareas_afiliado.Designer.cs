namespace ClinicaFrba
{
    partial class frm_tareas_afiliado
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
            this.but_comprar_bonos = new System.Windows.Forms.Button();
            this.but_pedir_turno = new System.Windows.Forms.Button();
            this.but_cancelar_atencion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_comprar_bonos
            // 
            this.but_comprar_bonos.Location = new System.Drawing.Point(82, 37);
            this.but_comprar_bonos.Name = "but_comprar_bonos";
            this.but_comprar_bonos.Size = new System.Drawing.Size(121, 27);
            this.but_comprar_bonos.TabIndex = 7;
            this.but_comprar_bonos.Text = "Comprar Bonos";
            this.but_comprar_bonos.UseVisualStyleBackColor = true;
            this.but_comprar_bonos.Click += new System.EventHandler(this.but_comprar_bonos_Click);
            // 
            // but_pedir_turno
            // 
            this.but_pedir_turno.Location = new System.Drawing.Point(82, 90);
            this.but_pedir_turno.Name = "but_pedir_turno";
            this.but_pedir_turno.Size = new System.Drawing.Size(121, 27);
            this.but_pedir_turno.TabIndex = 8;
            this.but_pedir_turno.Text = "Pedir Turno";
            this.but_pedir_turno.UseVisualStyleBackColor = true;
            this.but_pedir_turno.Click += new System.EventHandler(this.but_pedir_turno_Click);
            // 
            // but_cancelar_atencion
            // 
            this.but_cancelar_atencion.Location = new System.Drawing.Point(82, 144);
            this.but_cancelar_atencion.Name = "but_cancelar_atencion";
            this.but_cancelar_atencion.Size = new System.Drawing.Size(121, 23);
            this.but_cancelar_atencion.TabIndex = 9;
            this.but_cancelar_atencion.Text = "Cancelar Atencion ";
            this.but_cancelar_atencion.UseVisualStyleBackColor = true;
            this.but_cancelar_atencion.Click += new System.EventHandler(this.but_cancelar_atencion_Click);
            // 
            // frm_tareas_afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.but_cancelar_atencion);
            this.Controls.Add(this.but_pedir_turno);
            this.Controls.Add(this.but_comprar_bonos);
            this.Name = "frm_tareas_afiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Afiliado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_comprar_bonos;
        private System.Windows.Forms.Button but_pedir_turno;
        private System.Windows.Forms.Button but_cancelar_atencion;
    }
}