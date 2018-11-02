using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace Parcial_Autos
{
    public partial class ValidarDeleteAutoForm : Form
    {
        public User user;
        public ValidarDeleteAutoForm()
        {
            InitializeComponent();
        }

        private void ValidarDeleteAutoForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            user = new User() { Usuario = txtUserName.Text, Pass = txtPassword.Text };
            DialogResult = DialogResult.OK;
        }
    }
}
