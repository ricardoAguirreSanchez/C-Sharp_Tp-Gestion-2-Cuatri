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
            this.but_registrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Buscar_turnos = new System.Windows.Forms.Button();
            this.but_buscar_medicos = new System.Windows.Forms.Button();
            this.dgv_especialidades = new System.Windows.Forms.DataGridView();
            this.dgv_listado_medicos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_Buscar_bono = new System.Windows.Forms.Button();
            this.dgv_bono_consulta_disponibles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_turnos_del_dia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_medicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bono_consulta_disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_del_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // but_registrar
            // 
            this.but_registrar.Location = new System.Drawing.Point(354, 245);
            this.but_registrar.Name = "but_registrar";
            this.but_registrar.Size = new System.Drawing.Size(127, 28);
            this.but_registrar.TabIndex = 4;
            this.but_registrar.Text = "Crear consulta";
            this.but_registrar.UseVisualStyleBackColor = true;
            this.but_registrar.Click += new System.EventHandler(this.but_registrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Buscar_turnos);
            this.groupBox1.Controls.Add(this.but_buscar_medicos);
            this.groupBox1.Controls.Add(this.dgv_especialidades);
            this.groupBox1.Controls.Add(this.dgv_listado_medicos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 320);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar medico";
            // 
            // but_Buscar_turnos
            // 
            this.but_Buscar_turnos.Location = new System.Drawing.Point(154, 291);
            this.but_Buscar_turnos.Name = "but_Buscar_turnos";
            this.but_Buscar_turnos.Size = new System.Drawing.Size(105, 23);
            this.but_Buscar_turnos.TabIndex = 14;
            this.but_Buscar_turnos.Text = "Buscar Turnos";
            this.but_Buscar_turnos.UseVisualStyleBackColor = true;
            this.but_Buscar_turnos.Click += new System.EventHandler(this.but_Buscar_turnos_Click);
            // 
            // but_buscar_medicos
            // 
            this.but_buscar_medicos.Location = new System.Drawing.Point(154, 151);
            this.but_buscar_medicos.Name = "but_buscar_medicos";
            this.but_buscar_medicos.Size = new System.Drawing.Size(105, 23);
            this.but_buscar_medicos.TabIndex = 13;
            this.but_buscar_medicos.Text = "Buscar Medicos";
            this.but_buscar_medicos.UseVisualStyleBackColor = true;
            this.but_buscar_medicos.Click += new System.EventHandler(this.but_buscar_medicos_Click);
            // 
            // dgv_especialidades
            // 
            this.dgv_especialidades.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_especialidades.AllowUserToAddRows = false;
            this.dgv_especialidades.AllowUserToDeleteRows = false;
            this.dgv_especialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_especialidades.Location = new System.Drawing.Point(6, 53);
            this.dgv_especialidades.Name = "dgv_especialidades";
            this.dgv_especialidades.ReadOnly = true;
            this.dgv_especialidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_especialidades.Size = new System.Drawing.Size(253, 92);
            this.dgv_especialidades.TabIndex = 12;
            this.dgv_especialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_especialidades_CellContentClick_3);
            // 
            // dgv_listado_medicos
            // 
            this.dgv_listado_medicos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_listado_medicos.AllowUserToAddRows = false;
            this.dgv_listado_medicos.AllowUserToDeleteRows = false;
            this.dgv_listado_medicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listado_medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado_medicos.Location = new System.Drawing.Point(9, 186);
            this.dgv_listado_medicos.Name = "dgv_listado_medicos";
            this.dgv_listado_medicos.ReadOnly = true;
            this.dgv_listado_medicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_listado_medicos.Size = new System.Drawing.Size(250, 92);
            this.dgv_listado_medicos.TabIndex = 11;
            this.dgv_listado_medicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_medicos_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Listado de medicos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Especialidad medica:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Buscar_bono);
            this.groupBox2.Controls.Add(this.dgv_bono_consulta_disponibles);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.but_registrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgv_turnos_del_dia);
            this.groupBox2.Location = new System.Drawing.Point(297, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 319);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear consulta";
            // 
            // but_Buscar_bono
            // 
            this.but_Buscar_bono.Location = new System.Drawing.Point(376, 112);
            this.but_Buscar_bono.Name = "but_Buscar_bono";
            this.but_Buscar_bono.Size = new System.Drawing.Size(105, 23);
            this.but_Buscar_bono.TabIndex = 22;
            this.but_Buscar_bono.Text = "Buscar Bonos";
            this.but_Buscar_bono.UseVisualStyleBackColor = true;
            this.but_Buscar_bono.Click += new System.EventHandler(this.but_Buscar_bono_Click);
            // 
            // dgv_bono_consulta_disponibles
            // 
            this.dgv_bono_consulta_disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bono_consulta_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bono_consulta_disponibles.Location = new System.Drawing.Point(162, 144);
            this.dgv_bono_consulta_disponibles.Name = "dgv_bono_consulta_disponibles";
            this.dgv_bono_consulta_disponibles.Size = new System.Drawing.Size(113, 129);
            this.dgv_bono_consulta_disponibles.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bono consulta por consumir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Listado de turnos:";
            // 
            // dgv_turnos_del_dia
            // 
            this.dgv_turnos_del_dia.AllowUserToAddRows = false;
            this.dgv_turnos_del_dia.AllowUserToDeleteRows = false;
            this.dgv_turnos_del_dia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_turnos_del_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnos_del_dia.Location = new System.Drawing.Point(18, 46);
            this.dgv_turnos_del_dia.Name = "dgv_turnos_del_dia";
            this.dgv_turnos_del_dia.ReadOnly = true;
            this.dgv_turnos_del_dia.Size = new System.Drawing.Size(463, 65);
            this.dgv_turnos_del_dia.TabIndex = 13;
            // 
            // frm_registrar_llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_registrar_llegada";
            this.Text = "Registrar Llegada";
            this.Load += new System.EventHandler(this.frm_registrar_llegada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_especialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado_medicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bono_consulta_disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos_del_dia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_registrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_listado_medicos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_turnos_del_dia;
        private System.Windows.Forms.DataGridView dgv_bono_consulta_disponibles;
        private System.Windows.Forms.DataGridView dgv_especialidades;
        private System.Windows.Forms.Button but_Buscar_turnos;
        private System.Windows.Forms.Button but_buscar_medicos;
        private System.Windows.Forms.Button but_Buscar_bono;
    }
}