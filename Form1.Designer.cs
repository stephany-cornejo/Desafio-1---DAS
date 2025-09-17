namespace DAS_Desafio_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAñadirLibro = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.lblLibros = new System.Windows.Forms.Label();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.borrowTab = new System.Windows.Forms.TabPage();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnEditarRegistro = new System.Windows.Forms.Button();
            this.btnAñadirRegistro = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.usersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.borrowTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.usersTab);
            this.tabControl1.Controls.Add(this.borrowTab);
            this.tabControl1.Controls.Add(this.statsTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.BackColor = System.Drawing.Color.White;
            this.booksTab.Controls.Add(this.txtAnio);
            this.booksTab.Controls.Add(this.lblAnio);
            this.booksTab.Controls.Add(this.txtAutor);
            this.booksTab.Controls.Add(this.lblAutor);
            this.booksTab.Controls.Add(this.txtTitulo);
            this.booksTab.Controls.Add(this.lblTitulo);
            this.booksTab.Controls.Add(this.btnDelete);
            this.booksTab.Controls.Add(this.btnUpdate);
            this.booksTab.Controls.Add(this.btnAñadirLibro);
            this.booksTab.Controls.Add(this.dgvLibros);
            this.booksTab.Controls.Add(this.lblLibros);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(784, 352);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Libros";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(24, 202);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(185, 20);
            this.txtAnio.TabIndex = 10;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(24, 175);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 9;
            this.lblAnio.Text = "Año";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(24, 141);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(185, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(24, 116);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 7;
            this.lblAutor.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(24, 84);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(81, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(81, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAñadirLibro
            // 
            this.btnAñadirLibro.Location = new System.Drawing.Point(81, 238);
            this.btnAñadirLibro.Name = "btnAñadirLibro";
            this.btnAñadirLibro.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirLibro.TabIndex = 2;
            this.btnAñadirLibro.Text = "Añadir";
            this.btnAñadirLibro.UseVisualStyleBackColor = true;
            this.btnAñadirLibro.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToOrderColumns = true;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(238, 66);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(516, 266);
            this.dgvLibros.TabIndex = 1;
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(310, 20);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(152, 23);
            this.lblLibros.TabIndex = 0;
            this.lblLibros.Text = "Administrar Libros";
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.txtCorreo);
            this.usersTab.Controls.Add(this.txtFullName);
            this.usersTab.Controls.Add(this.lblCorreo);
            this.usersTab.Controls.Add(this.label1);
            this.usersTab.Controls.Add(this.btnEliminarUsuario);
            this.usersTab.Controls.Add(this.btnEditarUsuario);
            this.usersTab.Controls.Add(this.btnAñadirUsuario);
            this.usersTab.Controls.Add(this.lblUsuarios);
            this.usersTab.Controls.Add(this.dgvUsuarios);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(784, 352);
            this.usersTab.TabIndex = 1;
            this.usersTab.Text = "Usuarios";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(22, 148);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(22, 90);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(187, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(19, 123);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Completo";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(69, 277);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(69, 235);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 3;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.Location = new System.Drawing.Point(69, 196);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirUsuario.TabIndex = 2;
            this.btnAñadirUsuario.Text = "Añadir";
            this.btnAñadirUsuario.UseVisualStyleBackColor = true;
            this.btnAñadirUsuario.Click += new System.EventHandler(this.btnAñadirUsuario_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(314, 21);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(173, 23);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Administrar Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(237, 66);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(522, 234);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // borrowTab
            // 
            this.borrowTab.Controls.Add(this.btnEliminarRegistro);
            this.borrowTab.Controls.Add(this.btnEditarRegistro);
            this.borrowTab.Controls.Add(this.btnAñadirRegistro);
            this.borrowTab.Controls.Add(this.dateTimePicker2);
            this.borrowTab.Controls.Add(this.label5);
            this.borrowTab.Controls.Add(this.label4);
            this.borrowTab.Controls.Add(this.dateTimePicker1);
            this.borrowTab.Controls.Add(this.cmbLibro);
            this.borrowTab.Controls.Add(this.label3);
            this.borrowTab.Controls.Add(this.cmbUsuarios);
            this.borrowTab.Controls.Add(this.label2);
            this.borrowTab.Controls.Add(this.lblPrestamos);
            this.borrowTab.Controls.Add(this.dgvPrestamos);
            this.borrowTab.Location = new System.Drawing.Point(4, 22);
            this.borrowTab.Name = "borrowTab";
            this.borrowTab.Padding = new System.Windows.Forms.Padding(3);
            this.borrowTab.Size = new System.Drawing.Size(784, 352);
            this.borrowTab.TabIndex = 2;
            this.borrowTab.Text = "Prestamos";
            this.borrowTab.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Location = new System.Drawing.Point(69, 303);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRegistro.TabIndex = 12;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.Location = new System.Drawing.Point(69, 273);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnEditarRegistro.TabIndex = 11;
            this.btnEditarRegistro.Text = "Editar";
            this.btnEditarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAñadirRegistro
            // 
            this.btnAñadirRegistro.Location = new System.Drawing.Point(69, 243);
            this.btnAñadirRegistro.Name = "btnAñadirRegistro";
            this.btnAñadirRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirRegistro.TabIndex = 10;
            this.btnAñadirRegistro.Text = "Añadir";
            this.btnAñadirRegistro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 205);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Devolución";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Préstamo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(16, 104);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(194, 21);
            this.cmbLibro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libro";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(16, 54);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(197, 21);
            this.cmbUsuarios.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(309, 20);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(187, 23);
            this.lblPrestamos.TabIndex = 1;
            this.lblPrestamos.Text = "Administrar Préstamos";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToOrderColumns = true;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(228, 63);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(528, 258);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // statsTab
            // 
            this.statsTab.Location = new System.Drawing.Point(4, 22);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statsTab.Size = new System.Drawing.Size(784, 352);
            this.statsTab.TabIndex = 3;
            this.statsTab.Text = "Estadisticas";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.booksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.usersTab.ResumeLayout(false);
            this.usersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.borrowTab.ResumeLayout(false);
            this.borrowTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage borrowTab;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAñadirLibro;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnAñadirUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnEditarRegistro;
        private System.Windows.Forms.Button btnAñadirRegistro;
    }
}

