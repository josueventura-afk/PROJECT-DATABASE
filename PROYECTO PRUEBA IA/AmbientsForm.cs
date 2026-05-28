using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class AmbientsForm : Form
    {
        public AmbientsForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            var f = new AmbientEditForm();
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var f = new AmbientSearchForm();
            f.ShowDialog();
        }
    }
}
