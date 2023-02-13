namespace Praca_Inz.UserControls
{
    partial class UserControl_homePage
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
            this.label_TakenPlacesCount = new System.Windows.Forms.Label();
            this.label_FreePlacesCount = new System.Windows.Forms.Label();
            this.btn_CloseBarrier = new System.Windows.Forms.Button();
            this.btn_OpenBarrier = new System.Windows.Forms.Button();
            this.btn_OpenParkingView = new FontAwesome.Sharp.IconButton();
            this.label_ActualTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_TakenPlaces = new System.Windows.Forms.Label();
            this.label_FreePlaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_TakenPlacesCount
            // 
            this.label_TakenPlacesCount.AutoSize = true;
            this.label_TakenPlacesCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TakenPlacesCount.ForeColor = System.Drawing.Color.Firebrick;
            this.label_TakenPlacesCount.Location = new System.Drawing.Point(366, 106);
            this.label_TakenPlacesCount.Name = "label_TakenPlacesCount";
            this.label_TakenPlacesCount.Size = new System.Drawing.Size(141, 30);
            this.label_TakenPlacesCount.TabIndex = 19;
            this.label_TakenPlacesCount.Text = "Brak danych";
            // 
            // label_FreePlacesCount
            // 
            this.label_FreePlacesCount.AutoSize = true;
            this.label_FreePlacesCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_FreePlacesCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_FreePlacesCount.Location = new System.Drawing.Point(366, 63);
            this.label_FreePlacesCount.Name = "label_FreePlacesCount";
            this.label_FreePlacesCount.Size = new System.Drawing.Size(141, 30);
            this.label_FreePlacesCount.TabIndex = 18;
            this.label_FreePlacesCount.Text = "Brak danych";
            // 
            // btn_CloseBarrier
            // 
            this.btn_CloseBarrier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CloseBarrier.Location = new System.Drawing.Point(142, 328);
            this.btn_CloseBarrier.Name = "btn_CloseBarrier";
            this.btn_CloseBarrier.Size = new System.Drawing.Size(75, 60);
            this.btn_CloseBarrier.TabIndex = 17;
            this.btn_CloseBarrier.Text = "Zamknij szlaban";
            this.btn_CloseBarrier.UseVisualStyleBackColor = true;
            this.btn_CloseBarrier.Click += new System.EventHandler(this.btn_CloseBarrier_Click);
            // 
            // btn_OpenBarrier
            // 
            this.btn_OpenBarrier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OpenBarrier.Location = new System.Drawing.Point(47, 328);
            this.btn_OpenBarrier.Name = "btn_OpenBarrier";
            this.btn_OpenBarrier.Size = new System.Drawing.Size(72, 60);
            this.btn_OpenBarrier.TabIndex = 16;
            this.btn_OpenBarrier.Text = "Otwórz szlaban";
            this.btn_OpenBarrier.UseVisualStyleBackColor = true;
            this.btn_OpenBarrier.Click += new System.EventHandler(this.btn_OpenBarrier_Click);
            // 
            // btn_OpenParkingView
            // 
            this.btn_OpenParkingView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OpenParkingView.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.btn_OpenParkingView.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btn_OpenParkingView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_OpenParkingView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OpenParkingView.Location = new System.Drawing.Point(47, 194);
            this.btn_OpenParkingView.Name = "btn_OpenParkingView";
            this.btn_OpenParkingView.Size = new System.Drawing.Size(170, 77);
            this.btn_OpenParkingView.TabIndex = 15;
            this.btn_OpenParkingView.Text = "Mapa parkingu";
            this.btn_OpenParkingView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OpenParkingView.UseVisualStyleBackColor = true;
            this.btn_OpenParkingView.Click += new System.EventHandler(this.btn_OpenParkingView_Click);
            // 
            // label_ActualTime
            // 
            this.label_ActualTime.AutoSize = true;
            this.label_ActualTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ActualTime.Location = new System.Drawing.Point(585, 214);
            this.label_ActualTime.Name = "label_ActualTime";
            this.label_ActualTime.Size = new System.Drawing.Size(139, 30);
            this.label_ActualTime.TabIndex = 14;
            this.label_ActualTime.Text = "Actual_Time";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(509, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // label_TakenPlaces
            // 
            this.label_TakenPlaces.AutoSize = true;
            this.label_TakenPlaces.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TakenPlaces.Location = new System.Drawing.Point(47, 106);
            this.label_TakenPlaces.Name = "label_TakenPlaces";
            this.label_TakenPlaces.Size = new System.Drawing.Size(295, 30);
            this.label_TakenPlaces.TabIndex = 12;
            this.label_TakenPlaces.Text = "Zajęte miejsca parkingowe:";
            // 
            // label_FreePlaces
            // 
            this.label_FreePlaces.AutoSize = true;
            this.label_FreePlaces.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_FreePlaces.Location = new System.Drawing.Point(47, 63);
            this.label_FreePlaces.Name = "label_FreePlaces";
            this.label_FreePlaces.Size = new System.Drawing.Size(296, 30);
            this.label_FreePlaces.TabIndex = 11;
            this.label_FreePlaces.Text = "Wolne miejsca parkingowe:";
            // 
            // UserControl_homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_TakenPlacesCount);
            this.Controls.Add(this.label_FreePlacesCount);
            this.Controls.Add(this.btn_CloseBarrier);
            this.Controls.Add(this.btn_OpenBarrier);
            this.Controls.Add(this.btn_OpenParkingView);
            this.Controls.Add(this.label_ActualTime);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_TakenPlaces);
            this.Controls.Add(this.label_FreePlaces);
            this.Enabled = false;
            this.Name = "UserControl_homePage";
            this.Size = new System.Drawing.Size(799, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_TakenPlacesCount;
        private Label label_FreePlacesCount;
        private Button btn_CloseBarrier;
        private Button btn_OpenBarrier;
        private FontAwesome.Sharp.IconButton btn_OpenParkingView;
        private Label label_ActualTime;
        private MonthCalendar monthCalendar1;
        private Label label_TakenPlaces;
        private Label label_FreePlaces;
    }
}
