namespace Banco
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.respuestabancotxt = new System.Windows.Forms.TextBox();
            this.acceptarbtn = new System.Windows.Forms.Button();
            this.tiempocreacion = new System.Windows.Forms.DateTimePicker();
            this.NombreBancotxt = new System.Windows.Forms.TextBox();
            this.IdBancotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ubicacionSucursalcombo = new System.Windows.Forms.ComboBox();
            this.returntxtbox = new System.Windows.Forms.TextBox();
            this.bottonSucursal = new System.Windows.Forms.Button();
            this.IdBancoSucursaltxt = new System.Windows.Forms.TextBox();
            this.Antiguedadtxt = new System.Windows.Forms.TextBox();
            this.CantEmpleadostxt = new System.Windows.Forms.TextBox();
            this.NombeSucursaltxt = new System.Windows.Forms.TextBox();
            this.IdSucursaltxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buscadorNombreBancotxt = new System.Windows.Forms.TextBox();
            this.resultadoBusquedatxt = new System.Windows.Forms.TextBox();
            this.buscartbtn = new System.Windows.Forms.Button();
            this.ubicacionSuccombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datagridSuc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 447);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.respuestabancotxt);
            this.tabPage1.Controls.Add(this.acceptarbtn);
            this.tabPage1.Controls.Add(this.tiempocreacion);
            this.tabPage1.Controls.Add(this.NombreBancotxt);
            this.tabPage1.Controls.Add(this.IdBancotxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Banco a Base de Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // respuestabancotxt
            // 
            this.respuestabancotxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.respuestabancotxt.Location = new System.Drawing.Point(18, 330);
            this.respuestabancotxt.Name = "respuestabancotxt";
            this.respuestabancotxt.ReadOnly = true;
            this.respuestabancotxt.Size = new System.Drawing.Size(515, 20);
            this.respuestabancotxt.TabIndex = 7;
            // 
            // acceptarbtn
            // 
            this.acceptarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.acceptarbtn.Location = new System.Drawing.Point(572, 313);
            this.acceptarbtn.Name = "acceptarbtn";
            this.acceptarbtn.Size = new System.Drawing.Size(163, 53);
            this.acceptarbtn.TabIndex = 6;
            this.acceptarbtn.Text = "Acceptar y Agregar";
            this.acceptarbtn.UseVisualStyleBackColor = false;
            this.acceptarbtn.Click += new System.EventHandler(this.acceptarbtn_Click);
            // 
            // tiempocreacion
            // 
            this.tiempocreacion.CustomFormat = "dd-MM-yyyy";
            this.tiempocreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tiempocreacion.Location = new System.Drawing.Point(355, 137);
            this.tiempocreacion.Name = "tiempocreacion";
            this.tiempocreacion.Size = new System.Drawing.Size(190, 20);
            this.tiempocreacion.TabIndex = 5;
            // 
            // NombreBancotxt
            // 
            this.NombreBancotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NombreBancotxt.Location = new System.Drawing.Point(294, 87);
            this.NombreBancotxt.Name = "NombreBancotxt";
            this.NombreBancotxt.Size = new System.Drawing.Size(252, 20);
            this.NombreBancotxt.TabIndex = 4;
            // 
            // IdBancotxt
            // 
            this.IdBancotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdBancotxt.Location = new System.Drawing.Point(294, 43);
            this.IdBancotxt.Name = "IdBancotxt";
            this.IdBancotxt.Size = new System.Drawing.Size(251, 20);
            this.IdBancotxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese Fecha de Creacion del Banco ( Dia/Mes/Año)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Nombre del Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Numero de Identificacion del Banco";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ubicacionSucursalcombo);
            this.tabPage2.Controls.Add(this.returntxtbox);
            this.tabPage2.Controls.Add(this.bottonSucursal);
            this.tabPage2.Controls.Add(this.IdBancoSucursaltxt);
            this.tabPage2.Controls.Add(this.Antiguedadtxt);
            this.tabPage2.Controls.Add(this.CantEmpleadostxt);
            this.tabPage2.Controls.Add(this.NombeSucursaltxt);
            this.tabPage2.Controls.Add(this.IdSucursaltxt);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Sucursal a Base de Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ubicacionSucursalcombo
            // 
            this.ubicacionSucursalcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ubicacionSucursalcombo.FormattingEnabled = true;
            this.ubicacionSucursalcombo.Items.AddRange(new object[] {
            "Norte",
            "Centro",
            "Sur"});
            this.ubicacionSucursalcombo.Location = new System.Drawing.Point(338, 126);
            this.ubicacionSucursalcombo.Name = "ubicacionSucursalcombo";
            this.ubicacionSucursalcombo.Size = new System.Drawing.Size(134, 21);
            this.ubicacionSucursalcombo.TabIndex = 14;
            // 
            // returntxtbox
            // 
            this.returntxtbox.Enabled = false;
            this.returntxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returntxtbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.returntxtbox.Location = new System.Drawing.Point(52, 346);
            this.returntxtbox.Name = "returntxtbox";
            this.returntxtbox.ReadOnly = true;
            this.returntxtbox.Size = new System.Drawing.Size(486, 20);
            this.returntxtbox.TabIndex = 13;
            // 
            // bottonSucursal
            // 
            this.bottonSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bottonSucursal.Location = new System.Drawing.Point(585, 327);
            this.bottonSucursal.Name = "bottonSucursal";
            this.bottonSucursal.Size = new System.Drawing.Size(169, 56);
            this.bottonSucursal.TabIndex = 12;
            this.bottonSucursal.Text = "Acceptar y Ingresar Sucursal";
            this.bottonSucursal.UseVisualStyleBackColor = false;
            this.bottonSucursal.Click += new System.EventHandler(this.bottonSucursal_Click);
            // 
            // IdBancoSucursaltxt
            // 
            this.IdBancoSucursaltxt.Location = new System.Drawing.Point(337, 277);
            this.IdBancoSucursaltxt.Name = "IdBancoSucursaltxt";
            this.IdBancoSucursaltxt.Size = new System.Drawing.Size(134, 20);
            this.IdBancoSucursaltxt.TabIndex = 11;
            // 
            // Antiguedadtxt
            // 
            this.Antiguedadtxt.Location = new System.Drawing.Point(338, 225);
            this.Antiguedadtxt.Name = "Antiguedadtxt";
            this.Antiguedadtxt.Size = new System.Drawing.Size(133, 20);
            this.Antiguedadtxt.TabIndex = 10;
            // 
            // CantEmpleadostxt
            // 
            this.CantEmpleadostxt.Location = new System.Drawing.Point(338, 175);
            this.CantEmpleadostxt.Name = "CantEmpleadostxt";
            this.CantEmpleadostxt.Size = new System.Drawing.Size(134, 20);
            this.CantEmpleadostxt.TabIndex = 9;
            // 
            // NombeSucursaltxt
            // 
            this.NombeSucursaltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NombeSucursaltxt.Location = new System.Drawing.Point(340, 73);
            this.NombeSucursaltxt.Name = "NombeSucursaltxt";
            this.NombeSucursaltxt.Size = new System.Drawing.Size(132, 20);
            this.NombeSucursaltxt.TabIndex = 7;
            // 
            // IdSucursaltxt
            // 
            this.IdSucursaltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IdSucursaltxt.Location = new System.Drawing.Point(340, 24);
            this.IdSucursaltxt.Name = "IdSucursaltxt";
            this.IdSucursaltxt.Size = new System.Drawing.Size(132, 20);
            this.IdSucursaltxt.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Identificacion del Banco de la Sucursal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Años Antiguedad de la Sucursal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Numero de Empleados en la Sucursal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ubicacion de La Sucursal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero Identificacion Sucursal";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buscadorNombreBancotxt);
            this.tabPage3.Controls.Add(this.resultadoBusquedatxt);
            this.tabPage3.Controls.Add(this.buscartbtn);
            this.tabPage3.Controls.Add(this.ubicacionSuccombo);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.datagridSuc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Buscar Sucursales";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buscadorNombreBancotxt
            // 
            this.buscadorNombreBancotxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.buscadorNombreBancotxt.Location = new System.Drawing.Point(198, 13);
            this.buscadorNombreBancotxt.Name = "buscadorNombreBancotxt";
            this.buscadorNombreBancotxt.Size = new System.Drawing.Size(169, 20);
            this.buscadorNombreBancotxt.TabIndex = 7;
            // 
            // resultadoBusquedatxt
            // 
            this.resultadoBusquedatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoBusquedatxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.resultadoBusquedatxt.Location = new System.Drawing.Point(372, 76);
            this.resultadoBusquedatxt.Name = "resultadoBusquedatxt";
            this.resultadoBusquedatxt.ReadOnly = true;
            this.resultadoBusquedatxt.Size = new System.Drawing.Size(318, 20);
            this.resultadoBusquedatxt.TabIndex = 6;
            // 
            // buscartbtn
            // 
            this.buscartbtn.Location = new System.Drawing.Point(525, 20);
            this.buscartbtn.Name = "buscartbtn";
            this.buscartbtn.Size = new System.Drawing.Size(166, 33);
            this.buscartbtn.TabIndex = 5;
            this.buscartbtn.Text = "Buscar Surcusal";
            this.buscartbtn.UseVisualStyleBackColor = true;
            this.buscartbtn.Click += new System.EventHandler(this.buscartbtn_Click);
            // 
            // ubicacionSuccombo
            // 
            this.ubicacionSuccombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ubicacionSuccombo.FormattingEnabled = true;
            this.ubicacionSuccombo.Items.AddRange(new object[] {
            "Norte",
            "Centro",
            "Sur"});
            this.ubicacionSuccombo.Location = new System.Drawing.Point(229, 46);
            this.ubicacionSuccombo.Name = "ubicacionSuccombo";
            this.ubicacionSuccombo.Size = new System.Drawing.Size(138, 21);
            this.ubicacionSuccombo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ubicacion Sucursal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nombre del Banco ( Case Sensitive)";
            // 
            // datagridSuc
            // 
            this.datagridSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSuc.Location = new System.Drawing.Point(30, 122);
            this.datagridSuc.Name = "datagridSuc";
            this.datagridSuc.Size = new System.Drawing.Size(688, 272);
            this.datagridSuc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker tiempocreacion;
        private System.Windows.Forms.TextBox NombreBancotxt;
        private System.Windows.Forms.TextBox IdBancotxt;
        private System.Windows.Forms.Button acceptarbtn;
        private System.Windows.Forms.TextBox IdBancoSucursaltxt;
        private System.Windows.Forms.TextBox Antiguedadtxt;
        private System.Windows.Forms.TextBox CantEmpleadostxt;
        private System.Windows.Forms.TextBox NombeSucursaltxt;
        private System.Windows.Forms.TextBox IdSucursaltxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bottonSucursal;
        private System.Windows.Forms.TextBox returntxtbox;
        private System.Windows.Forms.ComboBox ubicacionSucursalcombo;
        private System.Windows.Forms.TextBox respuestabancotxt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox ubicacionSuccombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagridSuc;
        private Oracle.DataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.Button buscartbtn;
        private System.Windows.Forms.TextBox resultadoBusquedatxt;
        private System.Windows.Forms.TextBox buscadorNombreBancotxt;
    }
}

