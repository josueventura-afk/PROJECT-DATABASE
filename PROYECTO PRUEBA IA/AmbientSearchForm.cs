using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROYECTO_PRUEBA_IA
{
    public partial class AmbientSearchForm : Form
    {
        // sample data store
        private static List<Ambient> ambients = new List<Ambient>()
        {
            new Ambient{ Codigo = "A001", Tipo = "Aula", Bloque = "A", Capacidad=30, Estado="Disponible", Caracteristicas=new List<string>{"Pupitres"} },
            new Ambient{ Codigo = "B002", Tipo = "Laboratorio", Bloque = "B", Capacidad=40, Estado="Mantenimiento", Caracteristicas=new List<string>{"Computadoras"} }
        };

        public AmbientSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string code = txtSearch.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Ingrese código de ambiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var found = ambients.Find(a => a.Codigo.ToUpper() == code);
            if (found != null)
            {
                var edit = new AmbientEditForm();
                // populate fields on edit form
                edit.LoadAmbient(found);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ambiente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Ambient
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Bloque { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public List<string> Caracteristicas { get; set; }
    }
}
