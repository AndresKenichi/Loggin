﻿
namespace Loggin
{
    partial class Inicio
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
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MantenimientoM = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosF = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosF = new System.Windows.Forms.ToolStripMenuItem();
            this.EquiposF = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcesosM = new System.Windows.Forms.ToolStripMenuItem();
            this.RegLoteF = new System.Windows.Forms.ToolStripMenuItem();
            this.RegEquiposF = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEquiposF = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesM = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeM = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(204, 22);
            this.Empleados.Text = "Empleados";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem5.Text = "Usuarios";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem6.Text = "Equipos";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem7.Text = "Marcas y Modelos";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItem8.Text = "Cargos y Departamentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MantenimientoM,
            this.ProcesosM,
            this.ReportesM,
            this.AcercaDeM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MantenimientoM
            // 
            this.MantenimientoM.Checked = true;
            this.MantenimientoM.CheckOnClick = true;
            this.MantenimientoM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MantenimientoM.DoubleClickEnabled = true;
            this.MantenimientoM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosF,
            this.UsuariosF,
            this.EquiposF});
            this.MantenimientoM.Name = "MantenimientoM";
            this.MantenimientoM.Size = new System.Drawing.Size(101, 20);
            this.MantenimientoM.Text = "Mantenimiento";
            // 
            // EmpleadosF
            // 
            this.EmpleadosF.Name = "EmpleadosF";
            this.EmpleadosF.Size = new System.Drawing.Size(132, 22);
            this.EmpleadosF.Text = "Empleados";
            this.EmpleadosF.Click += new System.EventHandler(this.EmpleadosF_Click);
            // 
            // UsuariosF
            // 
            this.UsuariosF.Name = "UsuariosF";
            this.UsuariosF.Size = new System.Drawing.Size(132, 22);
            this.UsuariosF.Text = "Usuarios";
            this.UsuariosF.Click += new System.EventHandler(this.UsuariosF_Click);
            // 
            // EquiposF
            // 
            this.EquiposF.Name = "EquiposF";
            this.EquiposF.Size = new System.Drawing.Size(132, 22);
            this.EquiposF.Text = "Equipos";
            this.EquiposF.Click += new System.EventHandler(this.EquiposF_Click);
            // 
            // ProcesosM
            // 
            this.ProcesosM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegLoteF,
            this.RegEquiposF,
            this.GestionEquiposF});
            this.ProcesosM.Name = "ProcesosM";
            this.ProcesosM.Size = new System.Drawing.Size(66, 20);
            this.ProcesosM.Text = "Procesos";
            // 
            // RegLoteF
            // 
            this.RegLoteF.Name = "RegLoteF";
            this.RegLoteF.Size = new System.Drawing.Size(165, 22);
            this.RegLoteF.Text = "Registrar Lote";
            this.RegLoteF.Click += new System.EventHandler(this.RegLoteF_Click);
            // 
            // RegEquiposF
            // 
            this.RegEquiposF.Name = "RegEquiposF";
            this.RegEquiposF.Size = new System.Drawing.Size(165, 22);
            this.RegEquiposF.Text = "Registrar Equipos";
            this.RegEquiposF.Click += new System.EventHandler(this.RegEquiposF_Click);
            // 
            // GestionEquiposF
            // 
            this.GestionEquiposF.Name = "GestionEquiposF";
            this.GestionEquiposF.Size = new System.Drawing.Size(165, 22);
            this.GestionEquiposF.Text = "Gestion Equipos";
            this.GestionEquiposF.Click += new System.EventHandler(this.GestionEquiposF_Click);
            // 
            // ReportesM
            // 
            this.ReportesM.Name = "ReportesM";
            this.ReportesM.Size = new System.Drawing.Size(65, 20);
            this.ReportesM.Text = "Reportes";
            // 
            // AcercaDeM
            // 
            this.AcercaDeM.Name = "AcercaDeM";
            this.AcercaDeM.Size = new System.Drawing.Size(72, 20);
            this.AcercaDeM.Text = "Acerca De";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(1048, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 537);
            this.panel1.TabIndex = 4;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem Procesos;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoM;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosF;
        private System.Windows.Forms.ToolStripMenuItem UsuariosF;
        private System.Windows.Forms.ToolStripMenuItem EquiposF;
        private System.Windows.Forms.ToolStripMenuItem ProcesosM;
        private System.Windows.Forms.ToolStripMenuItem RegLoteF;
        private System.Windows.Forms.ToolStripMenuItem RegEquiposF;
        private System.Windows.Forms.ToolStripMenuItem GestionEquiposF;
        private System.Windows.Forms.ToolStripMenuItem ReportesM;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeM;
        private System.Windows.Forms.Panel panel1;
    }
}