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
    public partial class Form1 : Form
    {
        private AutoBusiness _autoController = new AutoBusiness();
        List<AutoVM> list;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutopartes_Click(object sender, EventArgs e)
        {
            frmAutopartes autopartes = new frmAutopartes();
            autopartes.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadAutos();
            CalcularTotalAutos();
            if (list.Count != 0)
            {
                btnEliminar.Enabled = true;
                cmbFiltro.Enabled = true;
                txtFiltro.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                cmbFiltro.Enabled = false;
                txtFiltro.Enabled = false;
            }
        }

        private void CalcularTotalAutos()
        {
            List<AutoVM> aux = dgvAutos.DataSource as List<AutoVM>;
            lblCantidadAutos.Text = "Cantidad de Autos: " + aux.Count.ToString();
        }

        public void LoadAutos()
        {
            dgvAutos.DataSource = _autoController.traerTodos();
            list = dgvAutos.DataSource as List<AutoVM>;
            dgvAutos.Columns[0].Visible = false;
            dgvAutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarCombo()
        {
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbFiltro.DataSource = _autoController.GetFiltrosDisponibles();
            cmbFiltro.DisplayMember = "Descripcion";
            cmbFiltro.ValueMember = "Code";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AutoVM selected = (AutoVM)dgvAutos.CurrentRow.DataBoundItem;
            ValidarDeleteAutoForm frm = new ValidarDeleteAutoForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                if (_autoController.ValidateUser(frm.user))
                {
                    _autoController.eliminar(selected);
                    MessageBox.Show("Se elimino el auto con exito.");
                    list.Remove(selected);
                    dgvAutos.DataSource = null;
                    LoadList();
                }
                else
                    MessageBox.Show("Credenciales incorrectas, no se elimino el auto.");
            }
        }

        public void LoadList()
        {
            List<AutoVM> listFiltro = new List<AutoVM>();
            if (txtFiltro.Text == "")
                listFiltro = list;
            else
            {

                switch (cmbFiltro.SelectedItem)
                {
                    case null:
                        listFiltro = list;
                        break;
                    case "":
                        listFiltro = list;
                        break;
                    case "Marca":
                        listFiltro = list.FindAll(m => m.Marca.ToLower().Contains(txtFiltro.Text.ToLower()));
                        break;

                    case "Modelo":
                        listFiltro = list.FindAll(m => m.Modelo.ToLower().Contains(txtFiltro.Text.ToLower()));
                        break;

                    case "Color":
                        listFiltro = list.FindAll(m => m.Color.ToLower().Contains(txtFiltro.Text.ToLower()));
                        break;

                }

            }
            dgvAutos.DataSource = listFiltro;
            CalcularTotalAutos();
            dgvAutos.Columns[0].Visible = false;
            dgvAutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
