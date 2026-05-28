namespace PROYECTO_PRUEBA_IA
{
    partial class ReservationsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(70, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Usuario: -";
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(16, 50);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(560, 260);
            this.dgvReservations.TabIndex = 1;
            // Add simple visualization columns
            // setup columns: ReservaID, Ambiente, Responsable, Fecha, Hora Inicio, Hora Fin, Estado
            this.dgvReservations.ColumnCount = 7;
            this.dgvReservations.Columns[0].Name = "ReservaID";
            this.dgvReservations.Columns[1].Name = "Ambiente";
            this.dgvReservations.Columns[2].Name = "Responsable";
            this.dgvReservations.Columns[3].Name = "Fecha";
            this.dgvReservations.Columns[4].Name = "Hora Inicio";
            this.dgvReservations.Columns[5].Name = "Hora Fin";
            this.dgvReservations.Columns[6].Name = "Estado";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 330);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nueva Reserva";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(172, 330);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(140, 30);
            this.btnCurrent.TabIndex = 3;
            this.btnCurrent.Text = "Reservas vigentes";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar reserva";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReservationsForm
            // 
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button btnCancel;
    }
}
