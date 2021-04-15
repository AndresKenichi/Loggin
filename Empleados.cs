using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        public static implicit operator Empleados(ToolStripMenuItem v)
        {
            throw new NotImplementedException();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
