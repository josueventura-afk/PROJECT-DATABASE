using System;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class AmbientEditForm : Form
    {
        public AmbientEditForm()
        {
            InitializeComponent();
        }

        // Allow loading ambient data from AmbientSearchForm
        public void LoadAmbient(Ambient a)
        {
            if (a == null) return;
            txtCode.Text = a.Codigo;
            cmbType.SelectedItem = a.Tipo;
            cmbBlock.SelectedItem = a.Bloque;
            numCapacity.Value = a.Capacidad > 0 ? a.Capacidad : 1;
            cmbEstado.SelectedItem = a.Estado;
            // set features
            for (int i = 0; i < chkFeatures.Items.Count; i++)
            {
                chkFeatures.SetItemChecked(i, a.Caracteristicas != null && a.Caracteristicas.Contains(chkFeatures.Items[i].ToString()));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ambiente guardado (simulado).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
