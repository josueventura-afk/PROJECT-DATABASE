using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class ReservationEditForm : Form
    {
        private List<string> ambients = new List<string>();

        public ReservationEditForm()
        {
            InitializeComponent();
            UpdateAvailabilityPreview();
            dtpStart.ValueChanged += (s,e) => UpdateAvailabilityPreview();
            dtpEnd.ValueChanged += (s,e) => UpdateAvailabilityPreview();
            dtpDate.ValueChanged += (s,e) => UpdateAvailabilityPreview();
        }

        public void SetAmbients(List<string> list)
        {
            ambients = list;
            cmbAmbient.Items.Clear();
            foreach (var a in ambients) cmbAmbient.Items.Add(a);
            if (cmbAmbient.Items.Count>0) cmbAmbient.SelectedIndex = 0;
        }

        private void UpdateAvailabilityPreview()
        {
            // Simple availability: mark as libre if ambient not used in sample reservations
            // In real app query DB. Here we just show that all are available.
            lblAvailability.Text = "Disponibilidad: comprobar...";
            // Simulate simple check
            var available = ambients; // all available in this demo
            lblAvailability.Text = $"Disponibles: {string.Join(",", available)}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (cmbAmbient.SelectedItem==null)
            {
                MessageBox.Show("Seleccione un ambiente.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Reservation GetReservation()
        {
            return new Reservation
            {
                ReservaID = "R" + DateTime.Now.Ticks.ToString().Substring(10),
                Ambiente = cmbAmbient.SelectedItem?.ToString(),
                Responsable = "U000",
                Fecha = dtpDate.Value.Date,
                Start = dtpStart.Value.TimeOfDay,
                End = dtpEnd.Value.TimeOfDay,
                Estado = "Confirmada"
            };
        }
    }
}
