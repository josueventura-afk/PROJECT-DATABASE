using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class CancelReservationForm : Form
    {
        private List<Reservation> reservations;

        public CancelReservationForm(List<Reservation> reservationsList)
        {
            InitializeComponent();
            reservations = reservationsList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var reason = txtReason.Text.Trim();
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Ingrese código y motivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = reservations.FirstOrDefault(x => x.ReservaID == code);
            if (r == null)
            {
                MessageBox.Show("Reserva no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            r.Estado = "Cancelada";
            r.MotivoCancelacion = reason;
            MessageBox.Show("Reserva cancelada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
