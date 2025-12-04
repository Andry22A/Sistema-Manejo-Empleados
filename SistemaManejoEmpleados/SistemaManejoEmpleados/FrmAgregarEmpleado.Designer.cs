namespace SistemaManejoEmpleados
{
    partial class FrmAgregarEmpleado
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblAFP = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.lblARS = new System.Windows.Forms.Label();
            this.txtARS = new System.Windows.Forms.TextBox();
            this.lblISR = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(250, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Empleado";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(50, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 36);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtID.Location = new System.Drawing.Point(386, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(500, 41);
            this.txtID.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombre.Location = new System.Drawing.Point(50, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 36);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(386, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(500, 41);
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblApellido.Location = new System.Drawing.Point(50, 140);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(124, 36);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtApellido.Location = new System.Drawing.Point(386, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(500, 41);
            this.txtApellido.TabIndex = 6;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDepartamento.Location = new System.Drawing.Point(50, 180);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(200, 36);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbDepartamento.Location = new System.Drawing.Point(386, 180);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(500, 44);
            this.cmbDepartamento.TabIndex = 8;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCargo.Location = new System.Drawing.Point(50, 220);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(96, 36);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbCargo.Location = new System.Drawing.Point(386, 220);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(500, 44);
            this.cmbCargo.TabIndex = 10;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(50, 260);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(246, 36);
            this.lblFechaIngreso.TabIndex = 11;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(386, 260);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(500, 41);
            this.dtpFechaIngreso.TabIndex = 12;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSalario.Location = new System.Drawing.Point(50, 300);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(108, 36);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSalario.Location = new System.Drawing.Point(386, 300);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(500, 41);
            this.txtSalario.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEstado.Location = new System.Drawing.Point(50, 340);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(108, 36);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbEstado.Location = new System.Drawing.Point(386, 340);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(500, 44);
            this.cmbEstado.TabIndex = 16;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAFP.Location = new System.Drawing.Point(50, 380);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(74, 36);
            this.lblAFP.TabIndex = 17;
            this.lblAFP.Text = "AFP";
            // 
            // txtAFP
            // 
            this.txtAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAFP.Location = new System.Drawing.Point(386, 380);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(500, 41);
            this.txtAFP.TabIndex = 18;
            // 
            // lblARS
            // 
            this.lblARS.AutoSize = true;
            this.lblARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblARS.Location = new System.Drawing.Point(50, 420);
            this.lblARS.Name = "lblARS";
            this.lblARS.Size = new System.Drawing.Size(78, 36);
            this.lblARS.TabIndex = 19;
            this.lblARS.Text = "ARS";
            // 
            // txtARS
            // 
            this.txtARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtARS.Location = new System.Drawing.Point(386, 420);
            this.txtARS.Name = "txtARS";
            this.txtARS.Size = new System.Drawing.Size(500, 41);
            this.txtARS.TabIndex = 20;
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblISR.Location = new System.Drawing.Point(50, 460);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(65, 36);
            this.lblISR.TabIndex = 21;
            this.lblISR.Text = "ISR";
            // 
            // txtISR
            // 
            this.txtISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtISR.Location = new System.Drawing.Point(386, 460);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(500, 41);
            this.txtISR.TabIndex = 22;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTiempo.Location = new System.Drawing.Point(50, 500);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(306, 36);
            this.lblTiempo.TabIndex = 23;
            this.lblTiempo.Text = "Tiempo en la empresa";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTiempo.Location = new System.Drawing.Point(386, 500);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(500, 41);
            this.txtTiempo.TabIndex = 24;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGuardar.Location = new System.Drawing.Point(396, 548);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(596, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAgregarEmpleado
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1020, 671);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.lblARS);
            this.Controls.Add(this.txtARS);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label lblARS;
        private System.Windows.Forms.TextBox txtARS;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}