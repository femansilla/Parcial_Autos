using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial_Autos
{
    public partial class frmAutopartes : Form
    {
        public frmAutopartes()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro de que desea desasociar la autoparte? Deberá ingresar sus credenciales.", "Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAsociarAutopartes asociar = new frmAsociarAutopartes();
            asociar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
