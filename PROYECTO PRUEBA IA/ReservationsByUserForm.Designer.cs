namespace PROYECTO_PRUEBA_IA
{
    partial class ReservationsByUserForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvUserReservations = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario: -";
            // 
            // dgvUserReservations
            // 
            this.dgvUserReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserReservations.Location = new System.Drawing.Point(16, 50);
            this.dgvUserReservations.Name = "dgvUserReservations";
            this.dgvUserReservations.Size = new System.Drawing.Size(640, 260);
            this.dgvUserReservations.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler((s, e) => this.Close());
            // 
            // ReservationsByUserForm
            // 
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgvUserReservations);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReservationsByUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservas del usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgvUserReservations;
        private System.Windows.Forms.Button btnClose;
    }
}
