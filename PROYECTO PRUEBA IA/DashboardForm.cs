using System;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class DashboardForm : Form
    {
        private string role;
        private string userCode;
        public DashboardForm(string role, string userCode)
        {
            this.role = role;
            this.userCode = userCode;
            InitializeComponent();
            lblWelcome.Text = $"Bienvenido {userCode} ({role})";
            SetupByRole();
        }

        private void SetupByRole()
        {
            // Only admin can edit users and ambientes
            btnManageUsers.Enabled = role == "Administrador";
            btnManageAmbients.Enabled = role == "Administrador";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var f = new UsersForm();
            f.ShowDialog();
        }

        private void btnManageAmbients_Click(object sender, EventArgs e)
        {
            var f = new AmbientsForm();
            f.ShowDialog();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            var f = new ReservationsForm(userCode);
            f.ShowDialog();
        }

        private void btnManageCaracteristics_Click(object sender, EventArgs e)
        {
            // removed: characteristics managed within Ambients
        }

        private void btnManageBlocks_Click(object sender, EventArgs e)
        {
            // removed: blocks managed within Ambients
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var f = new ReportsForm();
            f.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var f = new EventsForm();
            f.ShowDialog();
        }
    }
}
