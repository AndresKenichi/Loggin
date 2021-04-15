using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 1080;
            this.Height = 620;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /*
        private void cerrarVentanas() {

            foreach (Form fmr in this.MdiChildren) {

                if (!fmr.Focused) {
                    fmr.Visible = false;
                    fmr.Dispose();
                }
            
            }
        }*/

            private void EmpleadosF_Click(object sender, EventArgs e)
        {
            Empleados m = new Empleados();
            /*
            bool ard = false;
            cerrarVentanas();
            foreach (Form f in Application.OpenForms) {
                if (f.Text == "Empleados") {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false) {
                Empleados m = new Empleados();
                m.MdiParent = this;
                m.Show();
            }
            */

            openChildForm(m);
        }

        private void EquiposF_Click(object sender, EventArgs e)
        {
            Equipos ee = new Equipos();
            /*
            bool ard = false;
            cerrarVentanas();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Equipos")
                {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false)
            {
                Equipos ee = new Equipos();
                ee.MdiParent = this;
                ee.Show();
            }
            */

            openChildForm(ee);
        }

        private void UsuariosF_Click(object sender, EventArgs e)
        {
            Usuarios uu = new Usuarios();
            /*
            bool ard = false;
            cerrarVentanas();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Usuarios")
                {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false)
            {
                Usuarios uu = new Usuarios();
                uu.MdiParent = this;
                uu.Show();
            }
            */
            openChildForm(uu);
        }

        private void RegLoteF_Click(object sender, EventArgs e)
        {
            RegistrarLote rgl = new RegistrarLote();
            /*
            bool ard = false;
            cerrarVentanas();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Registrar Lotes")
                {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false)
            {
                RegistrarLote rgl = new RegistrarLote();
                rgl.MdiParent = this;
                rgl.Show();
            }
            */
            openChildForm(rgl);
        }

        private void RegEquiposF_Click(object sender, EventArgs e)
        {
            RegistrarEquipos rge = new RegistrarEquipos();
            /*
            bool ard = false;

            cerrarVentanas();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Registrar Equipos")
                {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false)
            {
                RegistrarEquipos rge = new RegistrarEquipos();
                rge.MdiParent = this;
                rge.Show();
            }
            */
            openChildForm(rge);
        }

        private void GestionEquiposF_Click(object sender, EventArgs e)
        {
            
            GestionEquipos gse = new GestionEquipos();
            /*
            bool ard = false;
            cerrarVentanas();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gestion Equipos")
                {
                    ard = true;
                    f.Focus();
                    break;
                }
            }
            if (ard == false)
            {
                gse.MdiParent = this;
                gse.Show();
            }*/

            openChildForm(gse);
        }
        private Form activeForm = null;

        private void openChildForm(Form child) {

            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            panel1.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
