using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaManejoEmpleados
{
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cmbCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblARS = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtARS = new System.Windows.Forms.TextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(295, 292);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(500, 38);
            this.cboCargo.TabIndex = 54;
            this.cboCargo.Text = "(lista: Gerente, Asistente, Cajero, etc.)";
            this.cboCargo.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged_1);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSalario.Location = new System.Drawing.Point(241, 413);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(405, 37);
            this.txtSalario.TabIndex = 53;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSalario.Location = new System.Drawing.Point(100, 412);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(93, 30);
            this.lblSalario.TabIndex = 51;
            this.lblSalario.Text = "Salario";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click_1);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(99, 355);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(210, 30);
            this.lblFechaIngreso.TabIndex = 50;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            this.lblFechaIngreso.Click += new System.EventHandler(this.lblFechaIngreso_Click_1);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCargo.Location = new System.Drawing.Point(99, 300);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(83, 30);
            this.lblCargo.TabIndex = 49;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.lblCargo_Click_1);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblDepartamento.Location = new System.Drawing.Point(99, 241);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(175, 30);
            this.lblDepartamento.TabIndex = 48;
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click_1);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblApellido.Location = new System.Drawing.Point(99, 186);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(104, 30);
            this.lblApellido.TabIndex = 47;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNombre.Location = new System.Drawing.Point(99, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 30);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblID.Location = new System.Drawing.Point(99, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 30);
            this.lblID.TabIndex = 45;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancelar.Location = new System.Drawing.Point(546, 709);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(269, 88);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGuardar.Location = new System.Drawing.Point(241, 709);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(269, 88);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(347, 351);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(477, 37);
            this.dtpFechaIngreso.TabIndex = 42;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged_1);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtApellido.Location = new System.Drawing.Point(236, 185);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(406, 37);
            this.txtApellido.TabIndex = 41;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNombre.Location = new System.Drawing.Point(237, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(405, 37);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtID.Location = new System.Drawing.Point(151, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(405, 37);
            this.txtID.TabIndex = 39;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitulo.Location = new System.Drawing.Point(300, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 30);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "Agregar Empleado";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEstado.Location = new System.Drawing.Point(101, 461);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(92, 30);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAFP.Location = new System.Drawing.Point(101, 500);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(63, 30);
            this.lblAFP.TabIndex = 56;
            this.lblAFP.Text = "AFP";
            // 
            // lblARS
            // 
            this.lblARS.AutoSize = true;
            this.lblARS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblARS.Location = new System.Drawing.Point(101, 540);
            this.lblARS.Name = "lblARS";
            this.lblARS.Size = new System.Drawing.Size(66, 30);
            this.lblARS.TabIndex = 57;
            this.lblARS.Text = "ARS";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblISR.Location = new System.Drawing.Point(101, 583);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(55, 30);
            this.lblISR.TabIndex = 58;
            this.lblISR.Text = "ISR";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTiempo.Location = new System.Drawing.Point(101, 632);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(268, 30);
            this.lblTiempo.TabIndex = 59;
            this.lblTiempo.Text = "Tiempo en la empresa";
            // 
            // txtAFP
            // 
            this.txtAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAFP.Location = new System.Drawing.Point(241, 499);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(405, 37);
            this.txtAFP.TabIndex = 61;
            this.txtAFP.Text = "0.00";
            // 
            // txtARS
            // 
            this.txtARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtARS.Location = new System.Drawing.Point(241, 546);
            this.txtARS.Name = "txtARS";
            this.txtARS.Size = new System.Drawing.Size(405, 37);
            this.txtARS.TabIndex = 62;
            this.txtARS.Text = "0.00";
            // 
            // txtISR
            // 
            this.txtISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtISR.Location = new System.Drawing.Point(241, 589);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(405, 37);
            this.txtISR.TabIndex = 63;
            this.txtISR.Text = "0.00";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTiempo.Location = new System.Drawing.Point(378, 634);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(404, 37);
            this.txtTiempo.TabIndex = 64;
            this.txtTiempo.Text = "0 meses";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(295, 238);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(500, 38);
            this.cboDepartamento.TabIndex = 65;
            this.cboDepartamento.Text = "(lista: Administración, Ventas, RH, etc.)";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(241, 455);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(405, 38);
            this.cboEstado.TabIndex = 66;
            this.cboEstado.Text = "(Activo, Inactivo)";
            // 
            // FrmAgregarEmpleado
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 818);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.txtARS);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblARS);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.txtSalario);
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
            this.Name = "FrmAgregarEmpleado";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAgregarEmpleado_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox cboCargo;
        private TextBox txtSalario;
        private Label lblSalario;
        private Label lblFechaIngreso;
        private Label lblCargo;
        private Label lblDepartamento;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblID;
        private Button btnCancelar;
        private Button btnGuardar;
        private DateTimePicker dtpFechaIngreso;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private Label lblTitulo;

        private void lblTitulo_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmAgregarEmpleado_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCargo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click_1(object sender, EventArgs e)
        {

        }

        private void lblFechaIngreso_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCargo_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDepartamento_Click_1(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click_1(object sender, EventArgs e)
        {

        }

        private void lblID_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private Label lblEstado;
        private Label lblAFP;
        private Label lblARS;
        private Label lblISR;
        private Label lblTiempo;
        private TextBox txtAFP;
        private TextBox txtARS;
        private TextBox txtISR;
        private TextBox txtTiempo;
        private ComboBox cboDepartamento;
        private ComboBox cboEstado;
    }
}