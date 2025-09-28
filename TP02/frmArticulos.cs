using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prytp2_LP2
{
    public partial class frmConsultadearticulos : Form
    {
        public frmConsultadearticulos()
        {
            InitializeComponent();
            dgvArtuculos.CellClick += dgvArtuculos_CellClick;
        }

        private string textoCantidadBase;
        private string textoStockBase;
        private void Form1_Load(object sender, EventArgs e)
        {
            textoCantidadBase = lblCantidad.Text;
            textoStockBase = lblTotalenStock.Text;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArtuculos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvArtuculos.SelectedRows[0];

                const int COL_RUBRO = 3;

                string rubroSeleccionado = fila.Cells[COL_RUBRO].Value?.ToString();

                int contador = 0;


                for (int i = 0; i < dgvArtuculos.Rows.Count; i++)
                {
                    if (fila.Cells[COL_RUBRO].Value?.ToString() == rubroSeleccionado)
                    {
                        contador++;
                    }
                }
            }

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string rubroSeleccionado = cmbRubros.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(rubroSeleccionado))
            {
                CargarProductosPorRubro(rubroSeleccionado);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rubroSeleccionado = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(rubroSeleccionado))
            {
                CargarProductosPorRubro(rubroSeleccionado);
            }
        }

        private void CargarProductosPorRubro(string rubroSeleccionado)
        {
            dgvArtuculos.Rows.Clear();
            string[] lineas = File.ReadAllLines("ARTICULOS.dat");

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] campos = linea.Split(';').Where(c => !string.IsNullOrWhiteSpace(c)).ToArray();
                if (campos.Length < 5) continue;

                string codigo = campos[0];
                string descripcion = campos[1];
                decimal costo = decimal.Parse(campos[2]);
                string rubro = campos[3];
                int stock = int.Parse(campos[4]);

                if (rubro == rubroSeleccionado)
                {
                    decimal valorEnStock = costo * stock;
                    dgvArtuculos.Rows.Add(codigo, descripcion, costo.ToString("F2"), stock, valorEnStock.ToString("F2"));

                }
            }
        }

        private void dgvArtuculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvArtuculos.Rows[e.RowIndex];


            // Stock del producto seleccionado (columna 3)
            if (fila.Cells[3].Value != null)
            {

                // Cantidad de productos listados
                int cantidadProductos = dgvArtuculos.Rows.Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow);


                lblCantidad.Text = textoCantidadBase + "Cantidad de productos:" + " " + cantidadProductos;
                lblTotalenStock.Text = textoStockBase + "Stock:" + " " + fila.Cells[3].Value.ToString();

            }
        }

        private void frmConsultadearticulos_Load(object sender, EventArgs e)
        {
            try
            {
                // Leer todas las líneas del archivo RUBROS.DAT
                string[] rubros = File.ReadAllLines("RUBROS.DAT");
                // Cargar esas líneas en el ComboBox
                cmbRubros.Items.AddRange(rubros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los rubros: " + ex.Message);
            }
        }
        private void lblExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivo CSV|*.csv";
            saveFile.Title = "Guardar artículos filtrados";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    // Escribimos encabezados (igual que en la grilla)
                    writer.WriteLine("Código,Descripción,Costo,Rubro,Stock");

                    // Recorremos la grilla y exportamos fila por fila
                    foreach (DataGridViewRow fila in dgvArtuculos.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            string linea = string.Join(",",
                                fila.Cells[0].Value,
                                fila.Cells[1].Value,
                                fila.Cells[2].Value,
                                fila.Cells[3].Value,
                                fila.Cells[4].Value
                            );

                            writer.WriteLine(linea);
                        }
                    }
                }

                MessageBox.Show("Archivo CSV exportado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); // ventana modal
        }
    }
}
