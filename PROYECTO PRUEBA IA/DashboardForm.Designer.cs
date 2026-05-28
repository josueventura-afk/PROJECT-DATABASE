namespace PROYECTO_PRUEBA_IA
{
    partial class DashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageAmbients = new System.Windows.Forms.Button();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(24, 70);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 40);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Gestión de Usuarios";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageAmbients
            // 
            this.btnManageAmbients.Location = new System.Drawing.Point(240, 70);
            this.btnManageAmbients.Name = "btnManageAmbients";
            this.btnManageAmbients.Size = new System.Drawing.Size(200, 40);
            this.btnManageAmbients.TabIndex = 2;
            this.btnManageAmbients.Text = "Gestión de Ambientes";
            this.btnManageAmbients.UseVisualStyleBackColor = true;
            this.btnManageAmbients.Click += new System.EventHandler(this.btnManageAmbients_Click);
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Location = new System.Drawing.Point(24, 130);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(200, 40);
            this.btnManageReservations.TabIndex = 3;
            this.btnManageReservations.Text = "Reservas";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnManageCaracteristics
            // 
            this.btnReports.Location = new System.Drawing.Point(240, 130);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 40);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reportes";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManageBlocks
            // 
            this.btnEvents.Location = new System.Drawing.Point(24, 190);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(200, 40);
            this.btnEvents.TabIndex = 5;
            this.btnEvents.Text = "Eventos";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageAmbients);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageAmbients;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEvents;
    }
}
