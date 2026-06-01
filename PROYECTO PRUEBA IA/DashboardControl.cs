using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_PRUEBA_IA
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            LoadStatisticsAsync();
        }

        private async void LoadStatisticsAsync()
        {
            try
            {
                // load counts asynchronously
                var tUsers = Task.Run(() => Database.ExecuteScalarInt("SELECT COUNT(1) FROM USUARIO"));
                var tAmbs = Task.Run(() => Database.ExecuteScalarInt("SELECT COUNT(1) FROM AMBIENTE"));
                var tRes = Task.Run(() => Database.ExecuteScalarInt("SELECT COUNT(1) FROM RESERVA r JOIN DETALLE_HORARIO dh ON r.id_reserva = dh.id_reserva WHERE dh.fecha_especifica = @fecha AND r.id_estado_reserva <> (SELECT id_estado_reserva FROM ESTADO_RESERVA WHERE nombre_estado = 'Cancelado')", new SqlParameter("@fecha", DateTime.Today)));
                var tEvents = Task.Run(() => Database.ExecuteScalarInt("SELECT COUNT(1) FROM EVENTO WHERE fecha_inicio >= @fecha", new SqlParameter("@fecha", DateTime.Today)));

                await Task.WhenAll(tUsers, tAmbs, tRes, tEvents);

                lblUsersCount.Text = tUsers.Result.ToString();
                lblAmbientsCount.Text = tAmbs.Result.ToString();
                lblReservationsCount.Text = tRes.Result.ToString();
                lblEventsCount.Text = tEvents.Result.ToString();
            }
            catch (Exception ex)
            {
                // ignore and leave zeros
            }
        }
    }
}
