namespace SistemaManejoEmpleados
{
    partial class FrmEditarEmpleado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(275, 329);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(336, 44);
            this.cmbDepartamento.TabIndex = 37;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSalario.Location = new System.Drawing.Point(210, 501);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(405, 41);
            this.txtSalario.TabIndex = 36;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbCargo.Location = new System.Drawing.Point(201, 385);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(410, 41);
            this.cmbCargo.TabIndex = 35;
            this.cmbCargo.TextChanged += new System.EventHandler(this.cmbCargo_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalario.Location = new System.Drawing.Point(69, 504);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(108, 36);
            this.lblSalario.TabIndex = 34;
            this.lblSalario.Text = "Salario";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(68, 443);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(246, 36);
            this.lblFechaIngreso.TabIndex = 33;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            this.lblFechaIngreso.Click += new System.EventHandler(this.lblFechaIngreso_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCargo.Location = new System.Drawing.Point(68, 388);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(96, 36);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.lblCargo_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDepartamento.Location = new System.Drawing.Point(68, 329);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(200, 36);
            this.lblDepartamento.TabIndex = 31;
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblApellido.Location = new System.Drawing.Point(68, 274);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(124, 36);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombre.Location = new System.Drawing.Point(68, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 36);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(68, 167);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 36);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(515, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(269, 88);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGuardar.Location = new System.Drawing.Point(210, 581);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(269, 88);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(316, 439);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(477, 41);
            this.dtpFechaIngreso.TabIndex = 25;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtApellido.Location = new System.Drawing.Point(205, 273);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(406, 41);
            this.txtApellido.TabIndex = 24;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(206, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(405, 41);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtID.Location = new System.Drawing.Point(120, 167);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(405, 41);
            this.txtID.TabIndex = 22;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(269, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 36);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Editar Empleado";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // FrmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.ClientSize = new System.Drawing.Size(884, 700);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEditarEmpleado";
            this.Text = "FrmEditarEmpleado";
            this.Load += new System.EventHandler(this.FrmEditarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox cmbCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTitulo;
    }
}