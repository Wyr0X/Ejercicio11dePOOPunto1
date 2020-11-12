using Ejercicio11dePOOPunto1.Business;
using Ejercicio11dePOOPunto1.Model;
using System;
using System.Windows.Forms;

namespace Ejercicio11dePOOPunto1.View
{
    public partial class FormAgregarEditar : Form
    {
        private readonly ListaDeAutos lista;
        public Auto AutoAE { get; set; }

        public FormAgregarEditar(ListaDeAutos listaDeAutos)
        {
            InitializeComponent();

            lista = listaDeAutos;
        }

        private void FormAgregarEditar_Load(object sender, EventArgs e)
        {
            combustibleComboBox.Items.AddRange(Enum.GetNames(typeof(EnumCombustible)));
            combustibleComboBox.SelectedIndex = 0;

            if (AutoAE != null)
            {
                txtPatente.Text = AutoAE.Patente;
                txtMarca.Text = AutoAE.Marca;
                txtModelo.Text = AutoAE.Modelo;
                txtColor.Text = AutoAE.Color;
                combustibleComboBox.SelectedIndex = (int)(AutoAE.Combustible) - 1;
                numericAnio.Value = AutoAE.AnioDeFabricacion;
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (AutoAE == null)
                {
                    AutoAE = new Auto();

                    if (lista.ExistePatente(txtPatente.Text))
                    {
                        ShowError("La patente ya existe en la lista.");
                        return;
                    }
                }

                AutoAE.Patente = txtPatente.Text;
                AutoAE.Marca = txtMarca.Text;
                AutoAE.Modelo = txtModelo.Text;
                AutoAE.Color = txtColor.Text;
                AutoAE.Combustible = (EnumCombustible)Enum.Parse(typeof(EnumCombustible), combustibleComboBox.SelectedItem.ToString());
                AutoAE.AnioDeFabricacion = (int)numericAnio.Value;

                DialogResult = DialogResult.OK;
            }            
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                ShowError("La patente no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                ShowError("La marca no puede estar vacía.");
                    return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                ShowError("El modelo no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                ShowError("Indique el color para el auto.");
                return false;
            }

            return true;
        }

        private void ShowError(string error_message)
        {
            MessageBox.Show(this, error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
