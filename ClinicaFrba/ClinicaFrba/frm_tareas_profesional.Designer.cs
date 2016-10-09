namespace ClinicaFrba
{
    partial class frm_tareas_profesional
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
            this.but_registro_resultado = new System.Windows.Forms.Button();
            this.but_cancelar_atencion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_registro_resultado
            // 
            this.but_registro_resultado.Location = new System.Drawing.Point(82, 94);
            this.but_registro_resultado.Name = "but_registro_resultado";
            this.but_registro_resultado.Size = new System.Drawing.Size(121, 23);
            this.but_registro_resultado.TabIndex = 5;
            this.but_registro_resultado.Text = "Registro de Resultado";
            this.but_registro_resultado.UseVisualStyleBackColor = true;
            this.but_registro_resultado.Click += new System.EventHandler(this.but_registro_resultado_Click);
            // 
            // but_cancelar_atencion
            // 
            this.but_cancelar_atencion.Location = new System.Drawing.Point(82, 41);
            this.but_cancelar_atencion.Name = "but_cancelar_atencion";
            this.but_cancelar_atencion.Size = new System.Drawing.Size(121, 23);
            this.but_cancelar_atencion.TabIndex = 4;
            this.but_cancelar_atencion.Text = "Cancelar Atencion ";
            this.but_cancelar_atencion.UseVisualStyleBackColor = true;
            this.but_cancelar_atencion.Click += new System.EventHandler(this.but_cancelar_atencion_Click);
            // 
            // frm_tareas_profesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.but_registro_resultado);
            this.Controls.Add(this.but_cancelar_atencion);
            this.Name = "frm_tareas_profesional";
            this.Text = "Tareas Profesional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_registro_resultado;
        private System.Windows.Forms.Button but_cancelar_atencion;
    }
}