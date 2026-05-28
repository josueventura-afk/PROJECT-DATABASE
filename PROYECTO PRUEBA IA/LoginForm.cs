using System;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate user code and password (stub)
            var code = txtUsername.Text.Trim().ToUpper();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese código/usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: validar contra base de datos. Ahora: simple derivado por prefijo
            string role = "Estudiante";
            if (code.StartsWith("DOC")) role = "Docente";
            if (code.StartsWith("ADM")) role = "Administrador";

            var dash = new DashboardForm(role, code);
            dash.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
