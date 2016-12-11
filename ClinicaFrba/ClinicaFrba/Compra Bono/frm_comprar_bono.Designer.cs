namespace ClinicaFrba.Compra_Bono
{
    partial class frm_comprar_bono
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
            this.but_comprar = new System.Windows.Forms.Button();
            this.tex_numero_afiliado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_total = new System.Windows.Forms.TextBox();
            this.rbn_bono_consulta = new System.Windows.Forms.RadioButton();
            this.rbn_bono_farmacia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tex_cant_bono_consulta = new System.Windows.Forms.TextBox();
            this.tex_cant_bono_farmacia = new System.Windows.Forms.TextBox();
            this.but_calcular = new System.Windows.Forms.Button();
            this.but_verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de afiliado:";
            // 
            // but_comprar
            // 
            this.but_comprar.Location = new System.Drawing.Point(85, 222);
            this.but_comprar.Name = "but_comprar";
            this.but_comprar.Size = new System.Drawing.Size(74, 31);
            this.but_comprar.TabIndex = 1;
            this.but_comprar.Text = "Comprar";
            this.but_comprar.UseVisualStyleBackColor = true;
            this.but_comprar.Click += new System.EventHandler(this.but_comprar_Click);
            // 
            // tex_numero_afiliado
            // 
            this.tex_numero_afiliado.Location = new System.Drawing.Point(116, 16);
            this.tex_numero_afiliado.Name = "tex_numero_afiliado";
            this.tex_numero_afiliado.Size = new System.Drawing.Size(100, 20);
            this.tex_numero_afiliado.TabIndex = 2;
            this.tex_numero_afiliado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOTAL:";
            // 
            // tex_total
            // 
            this.tex_total.Location = new System.Drawing.Point(149, 194);
            this.tex_total.Name = "tex_total";
            this.tex_total.Size = new System.Drawing.Size(100, 20);
            this.tex_total.TabIndex = 4;
            // 
            // rbn_bono_consulta
            // 
            this.rbn_bono_consulta.AutoSize = true;
            this.rbn_bono_consulta.Location = new System.Drawing.Point(13, 61);
            this.rbn_bono_consulta.Name = "rbn_bono_consulta";
            this.rbn_bono_consulta.Size = new System.Drawing.Size(130, 17);
            this.rbn_bono_consulta.TabIndex = 5;
            this.rbn_bono_consulta.TabStop = true;
            this.rbn_bono_consulta.Text = "Bono consulta medica";
            this.rbn_bono_consulta.UseVisualStyleBackColor = true;
            this.rbn_bono_consulta.CheckedChanged += new System.EventHandler(this.rbn_bono_consulta_CheckedChanged);
            // 
            // rbn_bono_farmacia
            // 
            this.rbn_bono_farmacia.AutoSize = true;
            this.rbn_bono_farmacia.Location = new System.Drawing.Point(13, 108);
            this.rbn_bono_farmacia.Name = "rbn_bono_farmacia";
            this.rbn_bono_farmacia.Size = new System.Drawing.Size(93, 17);
            this.rbn_bono_farmacia.TabIndex = 6;
            this.rbn_bono_farmacia.TabStop = true;
            this.rbn_bono_farmacia.Text = "Bono farmacia";
            this.rbn_bono_farmacia.UseVisualStyleBackColor = true;
            this.rbn_bono_farmacia.CheckedChanged += new System.EventHandler(this.rbn_bono_farmacia_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "cant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "cant:";
            // 
            // tex_cant_bono_consulta
            // 
            this.tex_cant_bono_consulta.Location = new System.Drawing.Point(201, 58);
            this.tex_cant_bono_consulta.Name = "tex_cant_bono_consulta";
            this.tex_cant_bono_consulta.Size = new System.Drawing.Size(48, 20);
            this.tex_cant_bono_consulta.TabIndex = 9;
            // 
            // tex_cant_bono_farmacia
            // 
            this.tex_cant_bono_farmacia.Location = new System.Drawing.Point(201, 107);
            this.tex_cant_bono_farmacia.Name = "tex_cant_bono_farmacia";
            this.tex_cant_bono_farmacia.Size = new System.Drawing.Size(48, 20);
            this.tex_cant_bono_farmacia.TabIndex = 10;
            // 
            // but_calcular
            // 
            this.but_calcular.Location = new System.Drawing.Point(85, 146);
            this.but_calcular.Name = "but_calcular";
            this.but_calcular.Size = new System.Drawing.Size(74, 31);
            this.but_calcular.TabIndex = 11;
            this.but_calcular.Text = "Calcular";
            this.but_calcular.UseVisualStyleBackColor = true;
            this.but_calcular.Click += new System.EventHandler(this.but_calcular_Click);
            // 
            // but_verificar
            // 
            this.but_verificar.Location = new System.Drawing.Point(222, 16);
            this.but_verificar.Name = "but_verificar";
            this.but_verificar.Size = new System.Drawing.Size(75, 23);
            this.but_verificar.TabIndex = 44;
            this.but_verificar.Text = "Verificar";
            this.but_verificar.UseVisualStyleBackColor = true;
            this.but_verificar.Click += new System.EventHandler(this.but_verificar_Click);
            // 
            // frm_comprar_bono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 265);
            this.Controls.Add(this.but_verificar);
            this.Controls.Add(this.but_calcular);
            this.Controls.Add(this.tex_cant_bono_farmacia);
            this.Controls.Add(this.tex_cant_bono_consulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbn_bono_farmacia);
            this.Controls.Add(this.rbn_bono_consulta);
            this.Controls.Add(this.tex_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_numero_afiliado);
            this.Controls.Add(this.but_comprar);
            this.Controls.Add(this.label1);
            this.Name = "frm_comprar_bono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar bono";
            this.Load += new System.EventHandler(this.frm_comprar_bono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_comprar;
        private System.Windows.Forms.TextBox tex_numero_afiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_total;
        private System.Windows.Forms.RadioButton rbn_bono_consulta;
        private System.Windows.Forms.RadioButton rbn_bono_farmacia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_cant_bono_consulta;
        private System.Windows.Forms.TextBox tex_cant_bono_farmacia;
        private System.Windows.Forms.Button but_calcular;
        private System.Windows.Forms.Button but_verificar;
    }
}