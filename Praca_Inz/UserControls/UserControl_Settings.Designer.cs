namespace Praca_Inz.UserControls
{
    partial class UserControl_Settings
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox_Connection = new System.Windows.Forms.GroupBox();
            this.btn_Disconn = new FontAwesome.Sharp.IconButton();
            this.btn_Connect = new FontAwesome.Sharp.IconButton();
            this.label_SpeedCon = new System.Windows.Forms.Label();
            this.cmbBox_SpeedSerial = new System.Windows.Forms.ComboBox();
            this.label_SelectPort = new System.Windows.Forms.Label();
            this.cmbBox_SelectPort = new System.Windows.Forms.ComboBox();
            this.grpBox_Connection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Connection
            // 
            this.grpBox_Connection.Controls.Add(this.btn_Disconn);
            this.grpBox_Connection.Controls.Add(this.btn_Connect);
            this.grpBox_Connection.Controls.Add(this.label_SpeedCon);
            this.grpBox_Connection.Controls.Add(this.cmbBox_SpeedSerial);
            this.grpBox_Connection.Controls.Add(this.label_SelectPort);
            this.grpBox_Connection.Controls.Add(this.cmbBox_SelectPort);
            this.grpBox_Connection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBox_Connection.Location = new System.Drawing.Point(24, 25);
            this.grpBox_Connection.Name = "grpBox_Connection";
            this.grpBox_Connection.Size = new System.Drawing.Size(353, 220);
            this.grpBox_Connection.TabIndex = 4;
            this.grpBox_Connection.TabStop = false;
            this.grpBox_Connection.Text = "Połączenie";
            // 
            // btn_Disconn
            // 
            this.btn_Disconn.Enabled = false;
            this.btn_Disconn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_Disconn.IconColor = System.Drawing.Color.Black;
            this.btn_Disconn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Disconn.IconSize = 30;
            this.btn_Disconn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Disconn.Location = new System.Drawing.Point(199, 146);
            this.btn_Disconn.Name = "btn_Disconn";
            this.btn_Disconn.Size = new System.Drawing.Size(114, 35);
            this.btn_Disconn.TabIndex = 6;
            this.btn_Disconn.Text = "      Rozłącz";
            this.btn_Disconn.UseVisualStyleBackColor = true;
            this.btn_Disconn.Click += new System.EventHandler(this.btn_Disconn_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btn_Connect.IconColor = System.Drawing.Color.Black;
            this.btn_Connect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Connect.IconSize = 30;
            this.btn_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Connect.Location = new System.Drawing.Point(13, 146);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(114, 35);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "      Połącz";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label_SpeedCon
            // 
            this.label_SpeedCon.AutoSize = true;
            this.label_SpeedCon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SpeedCon.Location = new System.Drawing.Point(186, 38);
            this.label_SpeedCon.Name = "label_SpeedCon";
            this.label_SpeedCon.Size = new System.Drawing.Size(139, 19);
            this.label_SpeedCon.TabIndex = 4;
            this.label_SpeedCon.Text = "Prędkość transmisji";
            // 
            // cmbBox_SpeedSerial
            // 
            this.cmbBox_SpeedSerial.AutoCompleteCustomSource.AddRange(new string[] {
            "115200"});
            this.cmbBox_SpeedSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_SpeedSerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBox_SpeedSerial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_SpeedSerial.FormattingEnabled = true;
            this.cmbBox_SpeedSerial.Items.AddRange(new object[] {
            "115200"});
            this.cmbBox_SpeedSerial.Location = new System.Drawing.Point(199, 72);
            this.cmbBox_SpeedSerial.Name = "cmbBox_SpeedSerial";
            this.cmbBox_SpeedSerial.Size = new System.Drawing.Size(114, 23);
            this.cmbBox_SpeedSerial.TabIndex = 3;
            // 
            // label_SelectPort
            // 
            this.label_SelectPort.AutoSize = true;
            this.label_SelectPort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SelectPort.Location = new System.Drawing.Point(13, 38);
            this.label_SelectPort.Name = "label_SelectPort";
            this.label_SelectPort.Size = new System.Drawing.Size(114, 19);
            this.label_SelectPort.TabIndex = 2;
            this.label_SelectPort.Text = "Port szeregowy";
            // 
            // cmbBox_SelectPort
            // 
            this.cmbBox_SelectPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_SelectPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBox_SelectPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_SelectPort.FormattingEnabled = true;
            this.cmbBox_SelectPort.Location = new System.Drawing.Point(13, 72);
            this.cmbBox_SelectPort.Name = "cmbBox_SelectPort";
            this.cmbBox_SelectPort.Size = new System.Drawing.Size(114, 23);
            this.cmbBox_SelectPort.TabIndex = 1;
            this.cmbBox_SelectPort.DropDown += new System.EventHandler(this.cmbBox_SelectPort_DropDown);
            // 
            // UserControl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBox_Connection);
            this.Name = "UserControl_Settings";
            this.Size = new System.Drawing.Size(646, 385);
            this.grpBox_Connection.ResumeLayout(false);
            this.grpBox_Connection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBox_Connection;
        private FontAwesome.Sharp.IconButton btn_Disconn;
        private FontAwesome.Sharp.IconButton btn_Connect;
        private Label label_SpeedCon;
        private ComboBox cmbBox_SpeedSerial;
        private Label label_SelectPort;
        private ComboBox cmbBox_SelectPort;
    }
}
