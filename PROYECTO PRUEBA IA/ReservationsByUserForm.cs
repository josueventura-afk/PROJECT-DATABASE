using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class ReservationsByUserForm : Form
    {
        private string userCode;
        private List<Reservation> reservations;

        public ReservationsByUserForm(string code, List<Reservation> reservationsList)
        {
            InitializeComponent();
            userCode = code;
            reservations = reservationsList;
            lblUser.Text = "Usuario: " + userCode;
            LoadUserReservations();
        }

        private void LoadUserReservations()
        {
            dgvUserReservations.Rows.Clear();
            foreach (var r in reservations.Where(x=> x.Responsable==userCode))
            {
                dgvUserReservations.Rows.Add(r.ReservaID, r.Ambiente, r.Fecha.ToShortDateString(), r.Start.ToString(), r.End.ToString(), r.Estado);
            }
        }
    }
}
