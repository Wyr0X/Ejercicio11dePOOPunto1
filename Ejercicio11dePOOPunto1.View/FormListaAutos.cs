using Ejercicio11dePOOPunto1.Business;
using Ejercicio11dePOOPunto1.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio11dePOOPunto1.View
{
    public partial class FrmLista : Form
    {
        private readonly ListaDeAutos listaDeAutos = new ListaDeAutos();
        private List<Auto> listaActual = new List<Auto>();

        public FrmLista()
        {
            InitializeComponent();

            // Cargo desde el archivo
            listaDeAutos.Leer();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            combustibleComboBox.Items.Add("No filtrar"); // Item index=0 usado para no filtrar
            combustibleComboBox.Items.AddRange(Enum.GetNames(typeof(EnumCombustible)));
            combustibleComboBox.SelectedIndex = 0;

            listaActual = listaDeAutos.GetLista();
            MostrarListaEnGridView();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            var Frm = new FormAgregarEditar(listaDeAutos)
            {
                Text = "Agregar auto"
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaDeAutos.Agregar(Frm.AutoAE);
                listaDeAutos.Guardar();
                MostrarListaEnGridView();
            }
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];
            int row_index = row.Index;

            var Frm = new FormAgregarEditar(listaDeAutos)
            {
                Text = "Editar auto",
                AutoAE = (Auto)row.Tag
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaDeAutos.Guardar();
                MostrarListaEnGridView();

                // Seleccionamos el que acaba de editar
                dataGridView.CurrentCell = dataGridView.Rows[row_index].Cells[0];
                dataGridView.ClearSelection();
                dataGridView.Rows[row_index].Selected = true;
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];
            Auto auto = (Auto)row.Tag;
            DialogResult dr = MessageBox.Show($"¿Borrar auto con patente {auto.Patente}?",
                "Cofirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;

            listaDeAutos.Eliminar(auto);
            listaDeAutos.Guardar();
            MostrarListaEnGridView();
        }

        private void MostrarListaEnGridView()
        {
            dataGridView.Rows.Clear();

            foreach (Auto auto in listaActual)
            {
                var row = CrearFila(auto);
                dataGridView.Rows.Add(row);
            }
        }

        private DataGridViewRow CrearFila(Auto auto)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView);

            row.Cells[0].Value = auto.Patente;
            row.Cells[1].Value = auto.Marca;
            row.Cells[2].Value = auto.Modelo;
            row.Cells[3].Value = auto.Color;
            row.Cells[4].Value = auto.Combustible;
            row.Cells[5].Value = auto.AnioDeFabricacion;
            row.Tag = auto;

            return row;
        }

        private void BotonRecargar_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.GetLista();
            MostrarListaEnGridView();
            BotonRecargar.Enabled = false;
        }

        private void OrdenarPatenteAZ_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorPatente(false);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarPatenteZA_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorPatente(true);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarMarcaAZ_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorMarca(false);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarMarcaZA_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorMarca(true);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarAnioNuevo_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorAnio(true);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarAnioAntiguo_Click(object sender, EventArgs e)
        {
            listaActual = listaDeAutos.OrdenarPorAnio(false);
            BotonRecargar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void FiltrarMarca_Click(object sender, EventArgs e)
        {
            var Frm = new FormFiltro()
            {
                Text = "Filtrar por marca"
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaActual = listaDeAutos.FiltrarPorMarca(Frm.Filtro);
                BotonRecargar.Enabled = true;
                MostrarListaEnGridView();
            }
        }

        private void FiltrarColor_Click(object sender, EventArgs e)
        {
            var Frm = new FormFiltro()
            {
                Text = "Filtrar por color"
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaActual = listaDeAutos.FiltrarPorColor(Frm.Filtro);
                BotonRecargar.Enabled = true;
                MostrarListaEnGridView();
            }
        }

        private void CombustibleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // El 0 es para no filtrar
            if (combustibleComboBox.SelectedIndex == 0)
            {
                listaActual = listaDeAutos.GetLista();
                BotonRecargar.Enabled = false;
                MostrarListaEnGridView();
            }
            else
            {
                listaActual = listaDeAutos.FiltrarPorCombustible(
                    (EnumCombustible)Enum.Parse(typeof(EnumCombustible), combustibleComboBox.SelectedItem.ToString())
                );
                BotonRecargar.Enabled = true;
                MostrarListaEnGridView();
            }
        }

        private void BotonEstadisticas_Click(object sender, EventArgs e)
        {
            // Lo hago en un MessageBox porque me agoté de crear formularios
            string Estadisticas = $"Autos totales: {listaDeAutos.GetCantidad()}\n";
            Estadisticas += $"Autos fabricados en este siglo: {listaDeAutos.GetCantidadAPartirAnio(2000)}\n";
            Estadisticas += $"Autos de color rojo: {listaDeAutos.GetCantidadDeColor("rojo")}\n";
            Estadisticas += $"Patentes terminadas en 3: {listaDeAutos.GetCantidadPatentesTerminaEn("3")}\n";

            MessageBox.Show(this, Estadisticas, "Estadísticas", MessageBoxButtons.OK);
        }
    }
}
