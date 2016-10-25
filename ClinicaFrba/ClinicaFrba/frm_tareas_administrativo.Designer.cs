namespace ClinicaFrba
{
    partial class frm_tareas_administrativo
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
            this.but_ir = new System.Windows.Forms.Button();
            this.dgv_listadoFuncionalidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Listado de Funcionalidades Disponibles:";
            // 
            // but_ir
            // 
            this.but_ir.Location = new System.Drawing.Point(133, 199);
            this.but_ir.Name = "but_ir";
            this.but_ir.Size = new System.Drawing.Size(75, 23);
            this.but_ir.TabIndex = 14;
            this.but_ir.Text = "IR";
            this.but_ir.UseVisualStyleBackColor = true;
            this.but_ir.Click += new System.EventHandler(this.but_ir_Click);
            // 
            // dgv_listadoFuncionalidades
            // 
            this.dgv_listadoFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listadoFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoFuncionalidades.Location = new System.Drawing.Point(15, 25);
            this.dgv_listadoFuncionalidades.Name = "dgv_listadoFuncionalidades";
            this.dgv_listadoFuncionalidades.Size = new System.Drawing.Size(193, 154);
            this.dgv_listadoFuncionalidades.TabIndex = 13;
            // 
            // frm_tareas_administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ir);
            this.Controls.Add(this.dgv_listadoFuncionalidades);
            this.Name = "frm_tareas_administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Administrativo";
            this.Load += new System.EventHandler(this.frm_tareas_administrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_ir;
        private System.Windows.Forms.DataGridView dgv_listadoFuncionalidades;
    }
}