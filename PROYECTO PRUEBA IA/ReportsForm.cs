using System;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Simulated: fill grids with dummy data
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            // For demo, add a couple rows
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "Resultado";
            dgv.Columns[1].Name = "Valor";
            dgv.Columns[2].Name = "Detalle";
            dgv.Rows.Add("Ejemplo", "123", "Demo");
            MessageBox.Show("Reporte generado (simulado).", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
