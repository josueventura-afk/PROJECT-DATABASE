namespace PROYECTO_PRUEBA_IA
{
    partial class DashboardControl
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
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardUsers = new System.Windows.Forms.Panel();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.cardAmbients = new System.Windows.Forms.Panel();
            this.lblAmbientsCount = new System.Windows.Forms.Label();
            this.lblAmbientsTitle = new System.Windows.Forms.Label();
            this.cardReservations = new System.Windows.Forms.Panel();
            this.lblReservationsCount = new System.Windows.Forms.Label();
            this.lblReservationsTitle = new System.Windows.Forms.Label();
            this.cardEvents = new System.Windows.Forms.Panel();
            this.lblEventsCount = new System.Windows.Forms.Label();
            this.lblEventsTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 32);
            this.lblWelcome.Text = "Bienvenido al sistema";
            // 
            // panelCards
            // 
            this.panelCards.Location = new System.Drawing.Point(20, 70);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(940, 200);
            this.panelCards.TabIndex = 1;
            // 
            // cardUsers
            // 
            this.cardUsers.BackColor = System.Drawing.Color.White;
            this.cardUsers.Location = new System.Drawing.Point(0, 0);
            this.cardUsers.Name = "cardUsers";
            this.cardUsers.Size = new System.Drawing.Size(220, 120);
            this.cardUsers.TabIndex = 0;
            this.cardUsers.Controls.Add(this.lblUsersCount);
            this.cardUsers.Controls.Add(this.lblUsersTitle);
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblUsersCount.Location = new System.Drawing.Point(16, 20);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(200, 40);
            this.lblUsersCount.Text = "0";
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsersTitle.Location = new System.Drawing.Point(16, 72);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(200, 20);
            this.lblUsersTitle.Text = "Total usuarios";
            // 
            // cardAmbients
            // 
            this.cardAmbients.BackColor = System.Drawing.Color.White;
            this.cardAmbients.Location = new System.Drawing.Point(240, 0);
            this.cardAmbients.Name = "cardAmbients";
            this.cardAmbients.Size = new System.Drawing.Size(220, 120);
            this.cardAmbients.TabIndex = 1;
            this.cardAmbients.Controls.Add(this.lblAmbientsCount);
            this.cardAmbients.Controls.Add(this.lblAmbientsTitle);
            // 
            // lblAmbientsCount
            // 
            this.lblAmbientsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAmbientsCount.Location = new System.Drawing.Point(16, 20);
            this.lblAmbientsCount.Name = "lblAmbientsCount";
            this.lblAmbientsCount.Size = new System.Drawing.Size(200, 40);
            this.lblAmbientsCount.Text = "0";
            // 
            // lblAmbientsTitle
            // 
            this.lblAmbientsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAmbientsTitle.Location = new System.Drawing.Point(16, 72);
            this.lblAmbientsTitle.Name = "lblAmbientsTitle";
            this.lblAmbientsTitle.Size = new System.Drawing.Size(200, 20);
            this.lblAmbientsTitle.Text = "Total ambientes";
            // 
            // cardReservations
            // 
            this.cardReservations.BackColor = System.Drawing.Color.White;
            this.cardReservations.Location = new System.Drawing.Point(480, 0);
            this.cardReservations.Name = "cardReservations";
            this.cardReservations.Size = new System.Drawing.Size(220, 120);
            this.cardReservations.TabIndex = 2;
            this.cardReservations.Controls.Add(this.lblReservationsCount);
            this.cardReservations.Controls.Add(this.lblReservationsTitle);
            // 
            // lblReservationsCount
            // 
            this.lblReservationsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblReservationsCount.Location = new System.Drawing.Point(16, 20);
            this.lblReservationsCount.Name = "lblReservationsCount";
            this.lblReservationsCount.Size = new System.Drawing.Size(200, 40);
            this.lblReservationsCount.Text = "0";
            // 
            // lblReservationsTitle
            // 
            this.lblReservationsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReservationsTitle.Location = new System.Drawing.Point(16, 72);
            this.lblReservationsTitle.Name = "lblReservationsTitle";
            this.lblReservationsTitle.Size = new System.Drawing.Size(200, 20);
            this.lblReservationsTitle.Text = "Reservas hoy";
            // 
            // cardEvents
            // 
            this.cardEvents.BackColor = System.Drawing.Color.White;
            this.cardEvents.Location = new System.Drawing.Point(720, 0);
            this.cardEvents.Name = "cardEvents";
            this.cardEvents.Size = new System.Drawing.Size(220, 120);
            this.cardEvents.TabIndex = 3;
            this.cardEvents.Controls.Add(this.lblEventsCount);
            this.cardEvents.Controls.Add(this.lblEventsTitle);
            // 
            // lblEventsCount
            // 
            this.lblEventsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblEventsCount.Location = new System.Drawing.Point(16, 20);
            this.lblEventsCount.Name = "lblEventsCount";
            this.lblEventsCount.Size = new System.Drawing.Size(200, 40);
            this.lblEventsCount.Text = "0";
            // 
            // lblEventsTitle
            // 
            this.lblEventsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEventsTitle.Location = new System.Drawing.Point(16, 72);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Size = new System.Drawing.Size(200, 20);
            this.lblEventsTitle.Text = "Eventos programados";
            // 
            // DashboardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.lblWelcome);
            this.panelCards.Controls.Add(this.cardUsers);
            this.panelCards.Controls.Add(this.cardAmbients);
            this.panelCards.Controls.Add(this.cardReservations);
            this.panelCards.Controls.Add(this.cardEvents);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(960, 520);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Panel cardAmbients;
        private System.Windows.Forms.Label lblAmbientsCount;
        private System.Windows.Forms.Label lblAmbientsTitle;
        private System.Windows.Forms.Panel cardReservations;
        private System.Windows.Forms.Label lblReservationsCount;
        private System.Windows.Forms.Label lblReservationsTitle;
        private System.Windows.Forms.Panel cardEvents;
        private System.Windows.Forms.Label lblEventsCount;
        private System.Windows.Forms.Label lblEventsTitle;
    }
}
