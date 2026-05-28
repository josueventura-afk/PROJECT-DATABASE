using System;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class UserEditForm : Form
    {
        public UserEditForm()
        {
            InitializeComponent();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbType.SelectedItem?.ToString();

            // Ocultar todos los campos adicionales primero
            lblCarrera.Visible = false;
            txtCarrera.Visible = false;
            lblArea.Visible = false;
            txtArea.Visible = false;

            // Mostrar según el tipo seleccionado
            if (selectedType == "Estudiante")
            {
                lblCarrera.Visible = true;
                txtCarrera.Visible = true;
                txtCarrera.Clear();
            }
            else if (selectedType == "Docente")
            {
                lblArea.Visible = true;
                txtArea.Visible = true;
                txtArea.Clear();
            }
            // Si es Administrador, no se muestra nada adicional
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario guardado (simulado).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
