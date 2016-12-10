namespace ClinicaFrba.AbmRol
{
    partial class frm_administrar_afiliados
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
            this.but_buscar = new System.Windows.Forms.Button();
            this.but_modificar = new System.Windows.Forms.Button();
            this.but_eliminar = new System.Windows.Forms.Button();
            this.tex_numero_afiliado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.tex_apellido = new System.Windows.Forms.TextBox();
            this.tex_dni = new System.Windows.Forms.TextBox();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.tex_telefono = new System.Windows.Forms.TextBox();
            this.tex_mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.rdb_femenino = new System.Windows.Forms.RadioButton();
            this.com_plan_medico = new System.Windows.Forms.ComboBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.but_cargarnuevo = new System.Windows.Forms.Button();
            this.but_descartarNuevo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.com_estado_civil = new System.Windows.Forms.ComboBox();
            this.cbxFamiliar = new System.Windows.Forms.CheckBox();
            this.txtDNITitular = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Afiliado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // but_buscar
            // 
            this.but_buscar.FlatAppearance.BorderSize = 3;
            this.but_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.but_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_buscar.Location = new System.Drawing.Point(15, 46);
            this.but_buscar.Name = "but_buscar";
            this.but_buscar.Size = new System.Drawing.Size(96, 29);
            this.but_buscar.TabIndex = 1;
            this.but_buscar.Text = "Buscar";
            this.but_buscar.UseVisualStyleBackColor = true;
            this.but_buscar.Click += new System.EventHandler(this.but_buscar_Click);
            // 
            // but_modificar
            // 
            this.but_modificar.Location = new System.Drawing.Point(21, 421);
            this.but_modificar.Name = "but_modificar";
            this.but_modificar.Size = new System.Drawing.Size(117, 48);
            this.but_modificar.TabIndex = 3;
            this.but_modificar.Text = "Modificar";
            this.but_modificar.UseVisualStyleBackColor = true;
            this.but_modificar.Click += new System.EventHandler(this.but_modificar_Click);
            // 
            // but_eliminar
            // 
            this.but_eliminar.Location = new System.Drawing.Point(178, 421);
            this.but_eliminar.Name = "but_eliminar";
            this.but_eliminar.Size = new System.Drawing.Size(131, 48);
            this.but_eliminar.TabIndex = 4;
            this.but_eliminar.Text = "Eliminar";
            this.but_eliminar.UseVisualStyleBackColor = true;
            this.but_eliminar.Click += new System.EventHandler(this.but_eliminar_Click);
            // 
            // tex_numero_afiliado
            // 
            this.tex_numero_afiliado.Location = new System.Drawing.Point(234, 51);
            this.tex_numero_afiliado.Name = "tex_numero_afiliado";
            this.tex_numero_afiliado.Size = new System.Drawing.Size(114, 20);
            this.tex_numero_afiliado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email:";
            // 
            // tex_nombre
            // 
            this.tex_nombre.Location = new System.Drawing.Point(144, 101);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(204, 20);
            this.tex_nombre.TabIndex = 13;
            // 
            // tex_apellido
            // 
            this.tex_apellido.Location = new System.Drawing.Point(144, 127);
            this.tex_apellido.Name = "tex_apellido";
            this.tex_apellido.Size = new System.Drawing.Size(204, 20);
            this.tex_apellido.TabIndex = 14;
            // 
            // tex_dni
            // 
            this.tex_dni.Location = new System.Drawing.Point(144, 152);
            this.tex_dni.Name = "tex_dni";
            this.tex_dni.Size = new System.Drawing.Size(204, 20);
            this.tex_dni.TabIndex = 15;
            // 
            // tex_direccion
            // 
            this.tex_direccion.Location = new System.Drawing.Point(144, 205);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(204, 20);
            this.tex_direccion.TabIndex = 17;
            // 
            // tex_telefono
            // 
            this.tex_telefono.Location = new System.Drawing.Point(144, 229);
            this.tex_telefono.Name = "tex_telefono";
            this.tex_telefono.Size = new System.Drawing.Size(204, 20);
            this.tex_telefono.TabIndex = 18;
            // 
            // tex_mail
            // 
            this.tex_mail.Location = new System.Drawing.Point(144, 255);
            this.tex_mail.Name = "tex_mail";
            this.tex_mail.Size = new System.Drawing.Size(204, 20);
            this.tex_mail.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sexo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Plan medico actual:";
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(185, 281);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_masculino.TabIndex = 22;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            this.rdb_masculino.CheckedChanged += new System.EventHandler(this.rdb_masculino_CheckedChanged);
            // 
            // rdb_femenino
            // 
            this.rdb_femenino.AutoSize = true;
            this.rdb_femenino.Location = new System.Drawing.Point(277, 281);
            this.rdb_femenino.Name = "rdb_femenino";
            this.rdb_femenino.Size = new System.Drawing.Size(71, 17);
            this.rdb_femenino.TabIndex = 23;
            this.rdb_femenino.TabStop = true;
            this.rdb_femenino.Text = "Femenino";
            this.rdb_femenino.UseVisualStyleBackColor = true;
            this.rdb_femenino.CheckedChanged += new System.EventHandler(this.rdb_femenino_CheckedChanged);
            // 
            // com_plan_medico
            // 
            this.com_plan_medico.FormattingEnabled = true;
            this.com_plan_medico.Items.AddRange(new object[] {
            "Plan Medico 110",
            "Plan Medico 120",
            "Plan Medico 130",
            "Plan Medico 140",
            "Plan Medico 150"});
            this.com_plan_medico.Location = new System.Drawing.Point(144, 338);
            this.com_plan_medico.Name = "com_plan_medico";
            this.com_plan_medico.Size = new System.Drawing.Size(204, 21);
            this.com_plan_medico.TabIndex = 24;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(14, 12);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(97, 28);
            this.Nuevo.TabIndex = 25;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // dtp_fecha_nacimiento
            // 
            this.dtp_fecha_nacimiento.Location = new System.Drawing.Point(144, 179);
            this.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento";
            this.dtp_fecha_nacimiento.Size = new System.Drawing.Size(204, 20);
            this.dtp_fecha_nacimiento.TabIndex = 29;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(374, 486);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 347;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 89;
            // 
            // but_cargarnuevo
            // 
            this.but_cargarnuevo.Location = new System.Drawing.Point(30, 421);
            this.but_cargarnuevo.Name = "but_cargarnuevo";
            this.but_cargarnuevo.Size = new System.Drawing.Size(124, 48);
            this.but_cargarnuevo.TabIndex = 31;
            this.but_cargarnuevo.Text = "Cargar nuevo afiliado";
            this.but_cargarnuevo.UseVisualStyleBackColor = true;
            this.but_cargarnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_descartarNuevo
            // 
            this.but_descartarNuevo.Location = new System.Drawing.Point(188, 421);
            this.but_descartarNuevo.Name = "but_descartarNuevo";
            this.but_descartarNuevo.Size = new System.Drawing.Size(131, 48);
            this.but_descartarNuevo.TabIndex = 32;
            this.but_descartarNuevo.Text = "Descartar";
            this.but_descartarNuevo.UseVisualStyleBackColor = true;
            this.but_descartarNuevo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Estado Civil:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // com_estado_civil
            // 
            this.com_estado_civil.FormattingEnabled = true;
            this.com_estado_civil.Items.AddRange(new object[] {
            "CASADO/A",
            "CONCUBINATO",
            "DIVORCIADO/A",
            "SOLTERO/A",
            "VIUDO/A"});
            this.com_estado_civil.Location = new System.Drawing.Point(144, 309);
            this.com_estado_civil.Name = "com_estado_civil";
            this.com_estado_civil.Size = new System.Drawing.Size(204, 21);
            this.com_estado_civil.TabIndex = 34;
            // 
            // cbxFamiliar
            // 
            this.cbxFamiliar.AutoSize = true;
            this.cbxFamiliar.Location = new System.Drawing.Point(16, 395);
            this.cbxFamiliar.Name = "cbxFamiliar";
            this.cbxFamiliar.Size = new System.Drawing.Size(82, 17);
            this.cbxFamiliar.TabIndex = 0;
            this.cbxFamiliar.Text = "Soy Familiar";
            this.cbxFamiliar.UseVisualStyleBackColor = true;
            this.cbxFamiliar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtDNITitular
            // 
            this.txtDNITitular.Enabled = false;
            this.txtDNITitular.Location = new System.Drawing.Point(221, 392);
            this.txtDNITitular.Name = "txtDNITitular";
            this.txtDNITitular.Size = new System.Drawing.Size(127, 20);
            this.txtDNITitular.TabIndex = 1;
            this.txtDNITitular.TextChanged += new System.EventHandler(this.txtDNITitular_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID del titular:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(185, 365);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(163, 23);
            this.btnHistorial.TabIndex = 35;
            this.btnHistorial.Text = "Consultar historial de planes";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // frm_administrar_afiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 486);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDNITitular);
            this.Controls.Add(this.cbxFamiliar);
            this.Controls.Add(this.com_estado_civil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.but_descartarNuevo);
            this.Controls.Add(this.but_cargarnuevo);
            this.Controls.Add(this.dtp_fecha_nacimiento);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.com_plan_medico);
            this.Controls.Add(this.rdb_femenino);
            this.Controls.Add(this.rdb_masculino);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tex_mail);
            this.Controls.Add(this.tex_telefono);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_dni);
            this.Controls.Add(this.tex_apellido);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_numero_afiliado);
            this.Controls.Add(this.but_eliminar);
            this.Controls.Add(this.but_modificar);
            this.Controls.Add(this.but_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frm_administrar_afiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Afiliados";
            this.Load += new System.EventHandler(this.frm_administrar_afiliados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_buscar;
        private System.Windows.Forms.Button but_modificar;
        private System.Windows.Forms.Button but_eliminar;
        private System.Windows.Forms.TextBox tex_numero_afiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.TextBox tex_apellido;
        private System.Windows.Forms.TextBox tex_dni;
        private System.Windows.Forms.TextBox tex_direccion;
        private System.Windows.Forms.TextBox tex_telefono;
        private System.Windows.Forms.TextBox tex_mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.RadioButton rdb_femenino;
        private System.Windows.Forms.ComboBox com_plan_medico;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nacimiento;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button but_cargarnuevo;
        private System.Windows.Forms.Button but_descartarNuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox com_estado_civil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDNITitular;
        private System.Windows.Forms.CheckBox cbxFamiliar;
        private System.Windows.Forms.Button btnHistorial;
    }
}