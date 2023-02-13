namespace Praca_Inz.UserControls
{
    partial class UserControl_Raports
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
            this.groupBox_raports = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayParkCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllParkCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_genRaport = new System.Windows.Forms.Button();
            this.groupBox_date = new System.Windows.Forms.GroupBox();
            this.dateTime_raport = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Places = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButton_Year = new System.Windows.Forms.RadioButton();
            this.rButton_Month = new System.Windows.Forms.RadioButton();
            this.rButton_day = new System.Windows.Forms.RadioButton();
            this.groupBox_raports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_date.SuspendLayout();
            this.groupBox_Places.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_raports
            // 
            this.groupBox_raports.Controls.Add(this.dataGridView1);
            this.groupBox_raports.Controls.Add(this.button_genRaport);
            this.groupBox_raports.Controls.Add(this.groupBox_date);
            this.groupBox_raports.Controls.Add(this.groupBox_Places);
            this.groupBox_raports.Controls.Add(this.groupBox1);
            this.groupBox_raports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_raports.Location = new System.Drawing.Point(30, 21);
            this.groupBox_raports.Name = "groupBox_raports";
            this.groupBox_raports.Size = new System.Drawing.Size(770, 379);
            this.groupBox_raports.TabIndex = 2;
            this.groupBox_raports.TabStop = false;
            this.groupBox_raports.Text = "Raporty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlaceName,
            this.LastPark,
            this.TodayParkCount,
            this.AllParkCount});
            this.dataGridView1.Location = new System.Drawing.Point(24, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 135);
            this.dataGridView1.TabIndex = 4;
            // 
            // PlaceName
            // 
            this.PlaceName.FillWeight = 142.132F;
            this.PlaceName.HeaderText = "Nazwa";
            this.PlaceName.Name = "PlaceName";
            this.PlaceName.ReadOnly = true;
            // 
            // LastPark
            // 
            this.LastPark.FillWeight = 149.7497F;
            this.LastPark.HeaderText = "Ostatnie parkowanie";
            this.LastPark.Name = "LastPark";
            this.LastPark.ReadOnly = true;
            // 
            // TodayParkCount
            // 
            this.TodayParkCount.FillWeight = 54.05916F;
            this.TodayParkCount.HeaderText = "Ilość parkowań (dziś)";
            this.TodayParkCount.Name = "TodayParkCount";
            this.TodayParkCount.ReadOnly = true;
            // 
            // AllParkCount
            // 
            this.AllParkCount.FillWeight = 54.05916F;
            this.AllParkCount.HeaderText = "Ilość parkowań (łącznie)";
            this.AllParkCount.Name = "AllParkCount";
            this.AllParkCount.ReadOnly = true;
            // 
            // button_genRaport
            // 
            this.button_genRaport.Location = new System.Drawing.Point(497, 111);
            this.button_genRaport.Name = "button_genRaport";
            this.button_genRaport.Size = new System.Drawing.Size(245, 42);
            this.button_genRaport.TabIndex = 3;
            this.button_genRaport.Text = "Generuj raport";
            this.button_genRaport.UseVisualStyleBackColor = true;
            this.button_genRaport.Click += new System.EventHandler(this.button_genRaport_Click);
            // 
            // groupBox_date
            // 
            this.groupBox_date.Controls.Add(this.dateTime_raport);
            this.groupBox_date.Location = new System.Drawing.Point(476, 38);
            this.groupBox_date.Name = "groupBox_date";
            this.groupBox_date.Size = new System.Drawing.Size(283, 67);
            this.groupBox_date.TabIndex = 2;
            this.groupBox_date.TabStop = false;
            this.groupBox_date.Text = "Data";
            // 
            // dateTime_raport
            // 
            this.dateTime_raport.Location = new System.Drawing.Point(21, 24);
            this.dateTime_raport.Name = "dateTime_raport";
            this.dateTime_raport.Size = new System.Drawing.Size(245, 25);
            this.dateTime_raport.TabIndex = 3;
            // 
            // groupBox_Places
            // 
            this.groupBox_Places.Controls.Add(this.radioButton13);
            this.groupBox_Places.Controls.Add(this.radioButton14);
            this.groupBox_Places.Controls.Add(this.radioButton15);
            this.groupBox_Places.Controls.Add(this.radioButton21);
            this.groupBox_Places.Controls.Add(this.radioButton22);
            this.groupBox_Places.Controls.Add(this.radioButton23);
            this.groupBox_Places.Controls.Add(this.radioButton11);
            this.groupBox_Places.Controls.Add(this.radioButton12);
            this.groupBox_Places.Controls.Add(this.radioButton16);
            this.groupBox_Places.Controls.Add(this.radioButton17);
            this.groupBox_Places.Controls.Add(this.radioButton18);
            this.groupBox_Places.Controls.Add(this.radioButton19);
            this.groupBox_Places.Controls.Add(this.radioButton20);
            this.groupBox_Places.Controls.Add(this.radioButton9);
            this.groupBox_Places.Controls.Add(this.radioButton8);
            this.groupBox_Places.Controls.Add(this.radioButton10);
            this.groupBox_Places.Controls.Add(this.radioButton7);
            this.groupBox_Places.Controls.Add(this.radioButton6);
            this.groupBox_Places.Controls.Add(this.radioButton5);
            this.groupBox_Places.Controls.Add(this.radioButton4);
            this.groupBox_Places.Controls.Add(this.radioButton3);
            this.groupBox_Places.Controls.Add(this.radioButton2);
            this.groupBox_Places.Controls.Add(this.radioButton1);
            this.groupBox_Places.Location = new System.Drawing.Point(146, 38);
            this.groupBox_Places.Name = "groupBox_Places";
            this.groupBox_Places.Size = new System.Drawing.Size(311, 170);
            this.groupBox_Places.TabIndex = 1;
            this.groupBox_Places.TabStop = false;
            this.groupBox_Places.Text = "Miejsce Parkingowe";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(216, 62);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(40, 21);
            this.radioButton13.TabIndex = 12;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "13";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(256, 62);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(40, 21);
            this.radioButton14.TabIndex = 13;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "14";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(13, 102);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(40, 21);
            this.radioButton15.TabIndex = 14;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "15";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(256, 102);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(40, 21);
            this.radioButton21.TabIndex = 20;
            this.radioButton21.TabStop = true;
            this.radioButton21.Text = "21";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(13, 142);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(40, 21);
            this.radioButton22.TabIndex = 21;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "22";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(56, 141);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(40, 21);
            this.radioButton23.TabIndex = 22;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "23";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(136, 62);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(40, 21);
            this.radioButton11.TabIndex = 10;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(176, 62);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(40, 21);
            this.radioButton12.TabIndex = 11;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(56, 102);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(40, 21);
            this.radioButton16.TabIndex = 15;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "16";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(96, 102);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(40, 21);
            this.radioButton17.TabIndex = 16;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "17";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(136, 102);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(40, 21);
            this.radioButton18.TabIndex = 17;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "18";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(176, 102);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(40, 21);
            this.radioButton19.TabIndex = 18;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "19";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(216, 102);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(40, 21);
            this.radioButton20.TabIndex = 19;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "20";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(56, 62);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(33, 21);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(13, 62);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(33, 21);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(96, 62);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(40, 21);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(256, 22);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(33, 21);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(216, 22);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(33, 21);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "";
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(176, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(33, 21);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "";
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(136, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(33, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "";
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(96, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(33, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "";
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "";
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "";
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButton_Year);
            this.groupBox1.Controls.Add(this.rButton_Month);
            this.groupBox1.Controls.Add(this.rButton_day);
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ Raportu";
            // 
            // rButton_Year
            // 
            this.rButton_Year.AutoSize = true;
            this.rButton_Year.Location = new System.Drawing.Point(6, 123);
            this.rButton_Year.Name = "rButton_Year";
            this.rButton_Year.Size = new System.Drawing.Size(69, 21);
            this.rButton_Year.TabIndex = 2;
            this.rButton_Year.TabStop = true;
            this.rButton_Year.Text = "Roczny";
            this.rButton_Year.UseVisualStyleBackColor = true;
            // 
            // rButton_Month
            // 
            this.rButton_Month.AutoSize = true;
            this.rButton_Month.Location = new System.Drawing.Point(6, 80);
            this.rButton_Month.Name = "rButton_Month";
            this.rButton_Month.Size = new System.Drawing.Size(93, 21);
            this.rButton_Month.TabIndex = 1;
            this.rButton_Month.TabStop = true;
            this.rButton_Month.Text = "Miesięczny";
            this.rButton_Month.UseVisualStyleBackColor = true;
            // 
            // rButton_day
            // 
            this.rButton_day.AutoSize = true;
            this.rButton_day.Location = new System.Drawing.Point(6, 37);
            this.rButton_day.Name = "rButton_day";
            this.rButton_day.Size = new System.Drawing.Size(76, 21);
            this.rButton_day.TabIndex = 0;
            this.rButton_day.TabStop = true;
            this.rButton_day.Text = "Dzienny";
            this.rButton_day.UseVisualStyleBackColor = true;
            // 
            // UserControl_Raports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_raports);
            this.Name = "UserControl_Raports";
            this.Size = new System.Drawing.Size(803, 413);
            this.groupBox_raports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_date.ResumeLayout(false);
            this.groupBox_Places.ResumeLayout(false);
            this.groupBox_Places.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_raports;
        private Button button_genRaport;
        private GroupBox groupBox_date;
        private DateTimePicker dateTime_raport;
        private GroupBox groupBox_Places;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton10;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton rButton_Year;
        private RadioButton rButton_Month;
        private RadioButton rButton_day;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PlaceName;
        private DataGridViewTextBoxColumn LastPark;
        private DataGridViewTextBoxColumn TodayParkCount;
        private DataGridViewTextBoxColumn AllParkCount;
    }
}
