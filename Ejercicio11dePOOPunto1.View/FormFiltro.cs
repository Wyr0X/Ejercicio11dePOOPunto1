using System;
using System.Windows.Forms;

namespace Ejercicio11dePOOPunto1.View
{
    public partial class FormFiltro : Form
    {
        public string Filtro { get; set; }

        public FormFiltro()
        {
            InitializeComponent();
        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtrar();
            }
        }

        private void Filtrar()
        {
            if (string.IsNullOrWhiteSpace(txtFiltro.Text))
            {
                MessageBox.Show(this, "Ingrese un texto para filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Filtro = txtFiltro.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
