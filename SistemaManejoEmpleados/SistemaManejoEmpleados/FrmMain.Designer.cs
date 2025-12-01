namespace SistemaManejoEmpleados
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCargToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarEmpleadosToolStripMenuItem,
            this.agregarEmpleadoToolStripMenuItem,
            this.actualizarEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDepartamentosToolStripMenuItem,
            this.agregarDepartamentoToolStripMenuItem,
            this.actualizarDepartamentoToolStripMenuItem,
            this.eliminarDepartamentoToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarCargosToolStripMenuItem,
            this.agregarCargoToolStripMenuItem,
            this.actualizarCargoToolStripMenuItem,
            this.eliminarCargToolStripMenuItem});
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar Empleados";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            // 
            // actualizarEmpleadoToolStripMenuItem
            // 
            this.actualizarEmpleadoToolStripMenuItem.Name = "actualizarEmpleadoToolStripMenuItem";
            this.actualizarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.actualizarEmpleadoToolStripMenuItem.Text = "Actualizar empleado";
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar empleado";
            // 
            // mostrarDepartamentosToolStripMenuItem
            // 
            this.mostrarDepartamentosToolStripMenuItem.Name = "mostrarDepartamentosToolStripMenuItem";
            this.mostrarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.mostrarDepartamentosToolStripMenuItem.Text = "Mostrar Departamentos";
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            this.agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            this.agregarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            // 
            // actualizarDepartamentoToolStripMenuItem
            // 
            this.actualizarDepartamentoToolStripMenuItem.Name = "actualizarDepartamentoToolStripMenuItem";
            this.actualizarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.actualizarDepartamentoToolStripMenuItem.Text = "Actualizar departamento";
            // 
            // eliminarDepartamentoToolStripMenuItem
            // 
            this.eliminarDepartamentoToolStripMenuItem.Name = "eliminarDepartamentoToolStripMenuItem";
            this.eliminarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(308, 34);
            this.eliminarDepartamentoToolStripMenuItem.Text = "Eliminar departamento";
            // 
            // mostrarCargosToolStripMenuItem
            // 
            this.mostrarCargosToolStripMenuItem.Name = "mostrarCargosToolStripMenuItem";
            this.mostrarCargosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mostrarCargosToolStripMenuItem.Text = "Mostrar Cargos ";
            // 
            // agregarCargoToolStripMenuItem
            // 
            this.agregarCargoToolStripMenuItem.Name = "agregarCargoToolStripMenuItem";
            this.agregarCargoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarCargoToolStripMenuItem.Text = "Agregar Cargo";
            // 
            // actualizarCargoToolStripMenuItem
            // 
            this.actualizarCargoToolStripMenuItem.Name = "actualizarCargoToolStripMenuItem";
            this.actualizarCargoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.actualizarCargoToolStripMenuItem.Text = "Actualizar Cargo";
            // 
            // eliminarCargToolStripMenuItem
            // 
            this.eliminarCargToolStripMenuItem.Name = "eliminarCargToolStripMenuItem";
            this.eliminarCargToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarCargToolStripMenuItem.Text = "Eliminar Cargo";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCargToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}