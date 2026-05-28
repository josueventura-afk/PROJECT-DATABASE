using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class ReservationsForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        private string currentUserCode = "-";

        public ReservationsForm(string userCode)
        {
            InitializeComponent();
            currentUserCode = userCode;
            lblInfo.Text = "Usuario: " + currentUserCode;
            LoadReservations();
        }

        private void LoadReservations()
        {
            // Example static data
            reservations = new List<Reservation>()
            {
                new Reservation{ ReservaID="R001", Ambiente="A001", Responsable="U001", Fecha=DateTime.Today, Start= new TimeSpan(9,0,0), End=new TimeSpan(11,0,0), Estado="Confirmada" },
                new Reservation{ ReservaID="R002", Ambiente="B002", Responsable="U002", Fecha=DateTime.Today.AddDays(1), Start= new TimeSpan(14,0,0), End=new TimeSpan(16,0,0), Estado="Confirmada" }
            };

            dgvReservations.Rows.Clear();
            foreach (var r in reservations)
            {
                dgvReservations.Rows.Add(r.ReservaID, r.Ambiente, r.Responsable, r.Fecha.ToShortDateString(), r.Start.ToString(), r.End.ToString(), r.Estado);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var f = new ReservationEditForm();
            // provide list of ambients
            f.SetAmbients(new List<string>{"A001","B002","C003"});
            if (f.ShowDialog() == DialogResult.OK)
            {
                // read new reservation
                var r = f.GetReservation();
                reservations.Add(r);
                LoadReservations();
            }
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            var f = new ReservationsByUserForm(currentUserCode, reservations);
            f.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var f = new CancelReservationForm(reservations);
            f.ShowDialog();
            // after cancellation reload
            LoadReservations();
        }
    }

    public class Reservation
    {
        public string ReservaID { get; set; }
        public string Ambiente { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Estado { get; set; }
        public string MotivoCancelacion { get; set; }
    }
}
