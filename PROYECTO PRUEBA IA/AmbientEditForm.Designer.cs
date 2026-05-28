namespace PROYECTO_PRUEBA_IA
{
    partial class AmbientEditForm
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblBlock = new System.Windows.Forms.Label();
            this.cmbBlock = new System.Windows.Forms.ComboBox();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.chkFeatures = new System.Windows.Forms.CheckedListBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 15);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código ambiente";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(20, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 23);
            this.txtCode.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(200, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 15);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Tipo ambiente";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] {"Aula", "Auditorio", "Sakib", "Coliseo", "Laboratorio", "Otro"});
            this.cmbType.Location = new System.Drawing.Point(200, 40);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 23);
            this.cmbType.TabIndex = 3;
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(20, 80);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(40, 15);
            this.lblBlock.TabIndex = 4;
            this.lblBlock.Text = "Bloque";
            // 
            // cmbBlock
            // 
            this.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlock.Items.AddRange(new object[] {"A", "B", "C", "D", "Otro"});
            this.cmbBlock.Location = new System.Drawing.Point(20, 100);
            this.cmbBlock.Name = "cmbBlock";
            this.cmbBlock.Size = new System.Drawing.Size(160, 23);
            this.cmbBlock.TabIndex = 5;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Location = new System.Drawing.Point(200, 80);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(80, 15);
            this.lblFeatures.TabIndex = 11;
            this.lblFeatures.Text = "Características";
            // 
            // chkFeatures
            // 
            this.chkFeatures.CheckOnClick = true;
            this.chkFeatures.Items.AddRange(new object[] {"Computadoras", "Pupitres", "Mesas con enchufes", "Equipo audiovisual", "Otros"});
            this.chkFeatures.Location = new System.Drawing.Point(200, 100);
            this.chkFeatures.Name = "chkFeatures";
            this.chkFeatures.Size = new System.Drawing.Size(200, 94);
            this.chkFeatures.TabIndex = 12;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(200, 80);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(60, 15);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "Capacidad";
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(200, 100);
            this.numCapacity.Minimum = 1;
            this.numCapacity.Maximum = 999;
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(80, 23);
            this.numCapacity.TabIndex = 7;
            this.numCapacity.Value = 30;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler((s, e) => this.Close());
            // 
            // AmbientEditForm
            // 
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.cmbBlock);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.chkFeatures);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AmbientEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear / Editar Ambiente";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ComboBox cmbBlock;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.CheckedListBox chkFeatures;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
