namespace ClinicaFrba.Registro_Resultado
{
    partial class frm_registro_resultado
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
            this.but_registrar = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.lab_fecha = new System.Windows.Forms.Label();
            this.tex_sintomas_diagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_registrar
            // 
            this.but_registrar.Location = new System.Drawing.Point(144, 257);
            this.but_registrar.Name = "but_registrar";
            this.but_registrar.Size = new System.Drawing.Size(75, 23);
            this.but_registrar.TabIndex = 0;
            this.but_registrar.Text = "Registrar";
            this.but_registrar.UseVisualStyleBackColor = true;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(135, 94);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 11;
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Location = new System.Drawing.Point(61, 32);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(34, 17);
            this.rb_si.TabIndex = 12;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "Si";
            this.rb_si.UseVisualStyleBackColor = true;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(215, 32);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(39, 17);
            this.rb_no.TabIndex = 13;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // lab_fecha
            // 
            this.lab_fecha.AutoSize = true;
            this.lab_fecha.Location = new System.Drawing.Point(29, 94);
            this.lab_fecha.Name = "lab_fecha";
            this.lab_fecha.Size = new System.Drawing.Size(40, 13);
            this.lab_fecha.TabIndex = 14;
            this.lab_fecha.Text = "Fecha:";
            // 
            // tex_sintomas_diagnostico
            // 
            this.tex_sintomas_diagnostico.Location = new System.Drawing.Point(196, 154);
            this.tex_sintomas_diagnostico.Multiline = true;
            this.tex_sintomas_diagnostico.Name = "tex_sintomas_diagnostico";
            this.tex_sintomas_diagnostico.Size = new System.Drawing.Size(156, 82);
            this.tex_sintomas_diagnostico.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Detalle de sintomas y diagnostico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asistencia:";
            // 
            // frm_registro_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tex_sintomas_diagnostico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_fecha);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.rb_si);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.but_registrar);
            this.Name = "frm_registro_resultado";
            this.Text = "Registrar Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_registrar;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Label lab_fecha;
        private System.Windows.Forms.TextBox tex_sintomas_diagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}