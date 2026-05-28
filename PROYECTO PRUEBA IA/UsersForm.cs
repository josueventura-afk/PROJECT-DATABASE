using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            var f = new UserEditForm();
            f.ShowDialog();
        }
    }
}
