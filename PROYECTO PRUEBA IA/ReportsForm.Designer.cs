namespace PROYECTO_PRUEBA_IA
{
    partial class ReportsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMostUsedAmbients = new System.Windows.Forms.TabPage();
            this.tabBusyHours = new System.Windows.Forms.TabPage();
            this.tabUsageByCareer = new System.Windows.Forms.TabPage();
            this.tabUsageByUserType = new System.Windows.Forms.TabPage();
            this.tabCancelled = new System.Windows.Forms.TabPage();
            this.tabAvailability = new System.Windows.Forms.TabPage();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabMostUsedAmbients.SuspendLayout();
            this.tabBusyHours.SuspendLayout();
            this.tabUsageByCareer.SuspendLayout();
            this.tabUsageByUserType.SuspendLayout();
            this.tabCancelled.SuspendLayout();
            this.tabAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMostUsedAmbients);
            this.tabControl.Controls.Add(this.tabBusyHours);
            this.tabControl.Controls.Add(this.tabUsageByCareer);
            this.tabControl.Controls.Add(this.tabUsageByUserType);
            this.tabControl.Controls.Add(this.tabCancelled);
            this.tabControl.Controls.Add(this.tabAvailability);
            this.tabControl.Location = new System.Drawing.Point(12, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 400);
            this.tabControl.TabIndex = 6;
            // 
            // tabMostUsedAmbients
            // 
            this.tabMostUsedAmbients.Controls.Add(this.dgv);
            this.tabMostUsedAmbients.Location = new System.Drawing.Point(4, 24);
            this.tabMostUsedAmbients.Name = "tabMostUsedAmbients";
            this.tabMostUsedAmbients.Padding = new System.Windows.Forms.Padding(3);
            this.tabMostUsedAmbients.Size = new System.Drawing.Size(752, 372);
            this.tabMostUsedAmbients.TabIndex = 0;
            this.tabMostUsedAmbients.Text = "Ambientes más usados";
            this.tabMostUsedAmbients.UseVisualStyleBackColor = true;
            // 
            // tabBusyHours
            // 
            this.tabBusyHours.Controls.Add(new System.Windows.Forms.DataGridView() { Dock = System.Windows.Forms.DockStyle.Fill });
            this.tabBusyHours.Location = new System.Drawing.Point(4, 24);
            this.tabBusyHours.Name = "tabBusyHours";
            this.tabBusyHours.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusyHours.Size = new System.Drawing.Size(752, 372);
            this.tabBusyHours.TabIndex = 1;
            this.tabBusyHours.Text = "Horarios más ocupados";
            this.tabBusyHours.UseVisualStyleBackColor = true;
            // 
            // tabUsageByCareer
            // 
            this.tabUsageByCareer.Controls.Add(new System.Windows.Forms.DataGridView() { Dock = System.Windows.Forms.DockStyle.Fill });
            this.tabUsageByCareer.Location = new System.Drawing.Point(4, 24);
            this.tabUsageByCareer.Name = "tabUsageByCareer";
            this.tabUsageByCareer.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsageByCareer.Size = new System.Drawing.Size(752, 372);
            this.tabUsageByCareer.TabIndex = 2;
            this.tabUsageByCareer.Text = "Uso por carrera";
            this.tabUsageByCareer.UseVisualStyleBackColor = true;
            // 
            // tabUsageByUserType
            // 
            this.tabUsageByUserType.Controls.Add(new System.Windows.Forms.DataGridView() { Dock = System.Windows.Forms.DockStyle.Fill });
            this.tabUsageByUserType.Location = new System.Drawing.Point(4, 24);
            this.tabUsageByUserType.Name = "tabUsageByUserType";
            this.tabUsageByUserType.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsageByUserType.Size = new System.Drawing.Size(752, 372);
            this.tabUsageByUserType.TabIndex = 3;
            this.tabUsageByUserType.Text = "Uso por tipo usuario";
            this.tabUsageByUserType.UseVisualStyleBackColor = true;
            // 
            // tabCancelled
            // 
            this.tabCancelled.Controls.Add(new System.Windows.Forms.DataGridView() { Dock = System.Windows.Forms.DockStyle.Fill });
            this.tabCancelled.Location = new System.Drawing.Point(4, 24);
            this.tabCancelled.Name = "tabCancelled";
            this.tabCancelled.Padding = new System.Windows.Forms.Padding(3);
            this.tabCancelled.Size = new System.Drawing.Size(752, 372);
            this.tabCancelled.TabIndex = 4;
            this.tabCancelled.Text = "Reservas canceladas";
            this.tabCancelled.UseVisualStyleBackColor = true;
            // 
            // tabAvailability
            // 
            this.tabAvailability.Controls.Add(new System.Windows.Forms.DataGridView() { Dock = System.Windows.Forms.DockStyle.Fill });
            this.tabAvailability.Location = new System.Drawing.Point(4, 24);
            this.tabAvailability.Name = "tabAvailability";
            this.tabAvailability.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailability.Size = new System.Drawing.Size(752, 372);
            this.tabAvailability.TabIndex = 5;
            this.tabAvailability.Text = "Disponibilidad";
            this.tabAvailability.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(80, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 23);
            this.dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(280, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 23);
            this.dtpTo.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(62, 15);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Fecha inicio";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(220, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(54, 15);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Fecha fin";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(420, 8);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 30);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generar reporte";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(746, 366);
            this.dgv.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.tabControl.ResumeLayout(false);
            this.tabMostUsedAmbients.ResumeLayout(false);
            this.tabBusyHours.ResumeLayout(false);
            this.tabUsageByCareer.ResumeLayout(false);
            this.tabUsageByUserType.ResumeLayout(false);
            this.tabCancelled.ResumeLayout(false);
            this.tabAvailability.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMostUsedAmbients;
        private System.Windows.Forms.TabPage tabBusyHours;
        private System.Windows.Forms.TabPage tabUsageByCareer;
        private System.Windows.Forms.TabPage tabUsageByUserType;
        private System.Windows.Forms.TabPage tabCancelled;
        private System.Windows.Forms.TabPage tabAvailability;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgv;
    }
}
