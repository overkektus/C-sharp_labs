namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_model = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_ListMembers = new System.Windows.Forms.ComboBox();
            this.Button_DeleteFromPlane = new System.Windows.Forms.Button();
            this.Button_AddToPlane = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_age = new System.Windows.Forms.NumericUpDown();
            this.TextBox_FIO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboBox_range = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CarryingСapacity = new System.Windows.Forms.TextBox();
            this.DateTimePicker_Maintenance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TrackBar_Carrying = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericUpDown_yearIssue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaskedTextBox_seats = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_JSON = new System.Windows.Forms.TextBox();
            this.Button_SaveToJSON = new System.Windows.Forms.Button();
            this.Button_ReadFromJSON = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clear = new System.Windows.Forms.Button();
            this.Button_AddAirplane = new System.Windows.Forms.Button();
            this.Button_DeleteAirplane = new System.Windows.Forms.Button();
            this.ComboBox_Airplane = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Carrying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_yearIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Location = new System.Drawing.Point(259, 19);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.Size = new System.Drawing.Size(138, 20);
            this.TextBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // ComboBox_type
            // 
            this.ComboBox_type.FormattingEnabled = true;
            this.ComboBox_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_type.Items.AddRange(new object[] {
            "военный",
            "грузовой",
            "пассажирский"});
            this.ComboBox_type.Location = new System.Drawing.Point(259, 45);
            this.ComboBox_type.Name = "ComboBox_type";
            this.ComboBox_type.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_type.TabIndex = 3;
            this.ComboBox_type.Text = "выберите тип....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Модель:";
            // 
            // ComboBox_model
            // 
            this.ComboBox_model.FormattingEnabled = true;
            this.ComboBox_model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_model.Items.AddRange(new object[] {
            "Airbus",
            "Bell",
            "Boeing",
            "Bombardier",
            "Cessna",
            "Vickers"});
            this.ComboBox_model.Location = new System.Drawing.Point(259, 74);
            this.ComboBox_model.Name = "ComboBox_model";
            this.ComboBox_model.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_model.TabIndex = 5;
            this.ComboBox_model.Text = "выберите модель....";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_ListMembers);
            this.groupBox1.Controls.Add(this.Button_DeleteFromPlane);
            this.groupBox1.Controls.Add(this.Button_AddToPlane);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CarryingСapacity);
            this.groupBox1.Controls.Add(this.DateTimePicker_Maintenance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TrackBar_Carrying);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NumericUpDown_yearIssue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaskedTextBox_seats);
            this.groupBox1.Controls.Add(this.TextBox_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_model);
            this.groupBox1.Controls.Add(this.ComboBox_type);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 379);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Самолет";
            // 
            // ComboBox_ListMembers
            // 
            this.ComboBox_ListMembers.FormattingEnabled = true;
            this.ComboBox_ListMembers.Location = new System.Drawing.Point(259, 290);
            this.ComboBox_ListMembers.Name = "ComboBox_ListMembers";
            this.ComboBox_ListMembers.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_ListMembers.TabIndex = 10;
            // 
            // Button_DeleteFromPlane
            // 
            this.Button_DeleteFromPlane.Location = new System.Drawing.Point(259, 327);
            this.Button_DeleteFromPlane.Name = "Button_DeleteFromPlane";
            this.Button_DeleteFromPlane.Size = new System.Drawing.Size(138, 23);
            this.Button_DeleteFromPlane.TabIndex = 16;
            this.Button_DeleteFromPlane.Text = "Удалить из самолета";
            this.Button_DeleteFromPlane.UseVisualStyleBackColor = true;
            // 
            // Button_AddToPlane
            // 
            this.Button_AddToPlane.Location = new System.Drawing.Point(259, 250);
            this.Button_AddToPlane.Name = "Button_AddToPlane";
            this.Button_AddToPlane.Size = new System.Drawing.Size(138, 23);
            this.Button_AddToPlane.TabIndex = 15;
            this.Button_AddToPlane.Text = "Добавить в самолет";
            this.Button_AddToPlane.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumericUpDown_);
            this.groupBox2.Controls.Add(this.NumericUpDown_age);
            this.groupBox2.Controls.Add(this.TextBox_FIO);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ComboBox_range);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Экипаж";
            // 
            // NumericUpDown_
            // 
            this.NumericUpDown_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDown_.Location = new System.Drawing.Point(188, 102);
            this.NumericUpDown_.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NumericUpDown_.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_.Name = "NumericUpDown_";
            this.NumericUpDown_.Size = new System.Drawing.Size(40, 20);
            this.NumericUpDown_.TabIndex = 20;
            this.NumericUpDown_.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NumericUpDown_age
            // 
            this.NumericUpDown_age.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDown_age.Location = new System.Drawing.Point(188, 75);
            this.NumericUpDown_age.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.NumericUpDown_age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumericUpDown_age.Name = "NumericUpDown_age";
            this.NumericUpDown_age.Size = new System.Drawing.Size(40, 20);
            this.NumericUpDown_age.TabIndex = 19;
            this.NumericUpDown_age.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // TextBox_FIO
            // 
            this.TextBox_FIO.Location = new System.Drawing.Point(90, 19);
            this.TextBox_FIO.Name = "TextBox_FIO";
            this.TextBox_FIO.Size = new System.Drawing.Size(138, 20);
            this.TextBox_FIO.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "ФИО:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Стаж:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Возраст:";
            // 
            // ComboBox_range
            // 
            this.ComboBox_range.FormattingEnabled = true;
            this.ComboBox_range.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_range.Items.AddRange(new object[] {
            "Командир",
            "Второй пилот",
            "Стюардесса"});
            this.ComboBox_range.Location = new System.Drawing.Point(90, 45);
            this.ComboBox_range.Name = "ComboBox_range";
            this.ComboBox_range.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_range.TabIndex = 15;
            this.ComboBox_range.Text = "выберите должность....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Должность:";
            // 
            // CarryingСapacity
            // 
            this.CarryingСapacity.Location = new System.Drawing.Point(141, 156);
            this.CarryingСapacity.Name = "CarryingСapacity";
            this.CarryingСapacity.ReadOnly = true;
            this.CarryingСapacity.Size = new System.Drawing.Size(26, 20);
            this.CarryingСapacity.TabIndex = 14;
            this.CarryingСapacity.Tag = "";
            this.CarryingСapacity.Text = "10";
            // 
            // DateTimePicker_Maintenance
            // 
            this.DateTimePicker_Maintenance.Location = new System.Drawing.Point(259, 193);
            this.DateTimePicker_Maintenance.MaxDate = new System.DateTime(2017, 4, 15, 0, 0, 0, 0);
            this.DateTimePicker_Maintenance.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker_Maintenance.Name = "DateTimePicker_Maintenance";
            this.DateTimePicker_Maintenance.Size = new System.Drawing.Size(138, 20);
            this.DateTimePicker_Maintenance.TabIndex = 13;
            this.DateTimePicker_Maintenance.Value = new System.DateTime(2017, 4, 15, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата последнего ТО:";
            // 
            // TrackBar_Carrying
            // 
            this.TrackBar_Carrying.Location = new System.Drawing.Point(173, 156);
            this.TrackBar_Carrying.Maximum = 100;
            this.TrackBar_Carrying.Minimum = 10;
            this.TrackBar_Carrying.Name = "TrackBar_Carrying";
            this.TrackBar_Carrying.Size = new System.Drawing.Size(227, 45);
            this.TrackBar_Carrying.TabIndex = 11;
            this.TrackBar_Carrying.Value = 10;
            this.TrackBar_Carrying.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Грузоподъемность:";
            // 
            // NumericUpDown_yearIssue
            // 
            this.NumericUpDown_yearIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumericUpDown_yearIssue.Location = new System.Drawing.Point(339, 102);
            this.NumericUpDown_yearIssue.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.NumericUpDown_yearIssue.Minimum = new decimal(new int[] {
            1976,
            0,
            0,
            0});
            this.NumericUpDown_yearIssue.Name = "NumericUpDown_yearIssue";
            this.NumericUpDown_yearIssue.Size = new System.Drawing.Size(58, 20);
            this.NumericUpDown_yearIssue.TabIndex = 9;
            this.NumericUpDown_yearIssue.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Год выпуска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество мест:";
            // 
            // MaskedTextBox_seats
            // 
            this.MaskedTextBox_seats.Location = new System.Drawing.Point(373, 130);
            this.MaskedTextBox_seats.Mask = "000";
            this.MaskedTextBox_seats.Name = "MaskedTextBox_seats";
            this.MaskedTextBox_seats.Size = new System.Drawing.Size(24, 20);
            this.MaskedTextBox_seats.TabIndex = 6;
            this.MaskedTextBox_seats.ValidatingType = typeof(int);
            // 
            // TextBox_JSON
            // 
            this.TextBox_JSON.Location = new System.Drawing.Point(447, 53);
            this.TextBox_JSON.Multiline = true;
            this.TextBox_JSON.Name = "TextBox_JSON";
            this.TextBox_JSON.Size = new System.Drawing.Size(373, 309);
            this.TextBox_JSON.TabIndex = 7;
            // 
            // Button_SaveToJSON
            // 
            this.Button_SaveToJSON.Location = new System.Drawing.Point(639, 368);
            this.Button_SaveToJSON.Name = "Button_SaveToJSON";
            this.Button_SaveToJSON.Size = new System.Drawing.Size(180, 25);
            this.Button_SaveToJSON.TabIndex = 8;
            this.Button_SaveToJSON.Text = "Сохранение в JSON";
            this.Button_SaveToJSON.UseVisualStyleBackColor = true;
            this.Button_SaveToJSON.Click += new System.EventHandler(this.Button_SaveToJSON_Click);
            // 
            // Button_ReadFromJSON
            // 
            this.Button_ReadFromJSON.Location = new System.Drawing.Point(447, 368);
            this.Button_ReadFromJSON.Name = "Button_ReadFromJSON";
            this.Button_ReadFromJSON.Size = new System.Drawing.Size(180, 25);
            this.Button_ReadFromJSON.TabIndex = 9;
            this.Button_ReadFromJSON.Text = "Чтение из JSON";
            this.Button_ReadFromJSON.UseVisualStyleBackColor = true;
            this.Button_ReadFromJSON.Click += new System.EventHandler(this.Button_ReadFromJSON_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.Filter = "Json файлы|*.json";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.Filter = "Json файлы|*.json";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(447, 22);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(372, 25);
            this.clear.TabIndex = 10;
            this.clear.Text = "очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Button_AddAirplane
            // 
            this.Button_AddAirplane.Location = new System.Drawing.Point(21, 422);
            this.Button_AddAirplane.Name = "Button_AddAirplane";
            this.Button_AddAirplane.Size = new System.Drawing.Size(180, 25);
            this.Button_AddAirplane.TabIndex = 11;
            this.Button_AddAirplane.Text = "Добавить самолет";
            this.Button_AddAirplane.UseVisualStyleBackColor = true;
            this.Button_AddAirplane.Click += new System.EventHandler(this.Button_AddAirplane_Click);
            // 
            // Button_DeleteAirplane
            // 
            this.Button_DeleteAirplane.Location = new System.Drawing.Point(232, 422);
            this.Button_DeleteAirplane.Name = "Button_DeleteAirplane";
            this.Button_DeleteAirplane.Size = new System.Drawing.Size(180, 25);
            this.Button_DeleteAirplane.TabIndex = 12;
            this.Button_DeleteAirplane.Text = "Удалить самолет";
            this.Button_DeleteAirplane.UseVisualStyleBackColor = true;
            this.Button_DeleteAirplane.Click += new System.EventHandler(this.Button_DeleteAirplane_Click);
            // 
            // ComboBox_Airplane
            // 
            this.ComboBox_Airplane.FormattingEnabled = true;
            this.ComboBox_Airplane.Location = new System.Drawing.Point(232, 395);
            this.ComboBox_Airplane.Name = "ComboBox_Airplane";
            this.ComboBox_Airplane.Size = new System.Drawing.Size(180, 21);
            this.ComboBox_Airplane.TabIndex = 17;
            this.ComboBox_Airplane.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Airplane_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 459);
            this.Controls.Add(this.ComboBox_Airplane);
            this.Controls.Add(this.Button_DeleteAirplane);
            this.Controls.Add(this.Button_AddAirplane);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Button_ReadFromJSON);
            this.Controls.Add(this.Button_SaveToJSON);
            this.Controls.Add(this.TextBox_JSON);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "lab7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Carrying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_yearIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox_seats;
        private System.Windows.Forms.NumericUpDown NumericUpDown_yearIssue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBar_Carrying;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Maintenance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CarryingСapacity;
        private System.Windows.Forms.TextBox TextBox_JSON;
        private System.Windows.Forms.Button Button_SaveToJSON;
        private System.Windows.Forms.Button Button_ReadFromJSON;
        private System.Windows.Forms.ComboBox ComboBox_ListMembers;
        private System.Windows.Forms.Button Button_DeleteFromPlane;
        private System.Windows.Forms.Button Button_AddToPlane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_FIO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboBox_range;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.NumericUpDown NumericUpDown_;
        private System.Windows.Forms.NumericUpDown NumericUpDown_age;
        private System.Windows.Forms.Button Button_AddAirplane;
        private System.Windows.Forms.Button Button_DeleteAirplane;
        private System.Windows.Forms.ComboBox ComboBox_Airplane;
    }
}

