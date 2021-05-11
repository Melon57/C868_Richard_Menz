
namespace C868_Richard_Menz
{
    partial class AppointmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLabel = new System.Windows.Forms.Label();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCusomterId = new System.Windows.Forms.Label();
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.appointmentTypeButton = new System.Windows.Forms.RadioButton();
            this.datesRadioButton = new System.Windows.Forms.RadioButton();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerIdRadioButton = new System.Windows.Forms.RadioButton();
            this.comboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(1, 7);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(798, 32);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Appointments for $\"{user}\": ";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(10, 52);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.Size = new System.Drawing.Size(480, 184);
            this.appointmentDataGridView.TabIndex = 3;
            this.appointmentDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.appointmentDataGridView_DataBindingComplete);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(560, 377);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(211, 44);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Back to Main";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(560, 192);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(211, 44);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(560, 132);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(211, 44);
            this.editButton.TabIndex = 27;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(560, 72);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(211, 44);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Search for appointments";
            // 
            // lblCusomterId
            // 
            this.lblCusomterId.AutoSize = true;
            this.lblCusomterId.Location = new System.Drawing.Point(165, 283);
            this.lblCusomterId.Name = "lblCusomterId";
            this.lblCusomterId.Size = new System.Drawing.Size(65, 13);
            this.lblCusomterId.TabIndex = 33;
            this.lblCusomterId.Text = "Customer ID";
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.AutoSize = true;
            this.lblAppointmentType.Location = new System.Drawing.Point(165, 316);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(93, 13);
            this.lblAppointmentType.TabIndex = 34;
            this.lblAppointmentType.Text = "Appointment Type";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(286, 347);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 35;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(165, 355);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 36;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(165, 387);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 37;
            this.lblEndDate.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(286, 387);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 38;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(286, 283);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(49, 20);
            this.txtCustomerID.TabIndex = 39;
            // 
            // appointmentTypeButton
            // 
            this.appointmentTypeButton.AutoSize = true;
            this.appointmentTypeButton.Location = new System.Drawing.Point(7, 316);
            this.appointmentTypeButton.Name = "appointmentTypeButton";
            this.appointmentTypeButton.Size = new System.Drawing.Size(111, 17);
            this.appointmentTypeButton.TabIndex = 43;
            this.appointmentTypeButton.TabStop = true;
            this.appointmentTypeButton.Text = "Appointment Type";
            this.appointmentTypeButton.UseVisualStyleBackColor = true;
            this.appointmentTypeButton.CheckedChanged += new System.EventHandler(this.customerRadioButton_CheckedChanged);
            // 
            // datesRadioButton
            // 
            this.datesRadioButton.AutoSize = true;
            this.datesRadioButton.Location = new System.Drawing.Point(7, 351);
            this.datesRadioButton.Name = "datesRadioButton";
            this.datesRadioButton.Size = new System.Drawing.Size(53, 17);
            this.datesRadioButton.TabIndex = 44;
            this.datesRadioButton.TabStop = true;
            this.datesRadioButton.Text = "Dates";
            this.datesRadioButton.UseVisualStyleBackColor = true;
            this.datesRadioButton.CheckedChanged += new System.EventHandler(this.datesRadioButton_CheckedChanged);
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(12, 254);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(68, 13);
            this.lblSearchType.TabIndex = 45;
            this.lblSearchType.Text = "Search Type";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(560, 316);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(211, 44);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerIdRadioButton
            // 
            this.customerIdRadioButton.AutoSize = true;
            this.customerIdRadioButton.Location = new System.Drawing.Point(7, 278);
            this.customerIdRadioButton.Name = "customerIdRadioButton";
            this.customerIdRadioButton.Size = new System.Drawing.Size(83, 17);
            this.customerIdRadioButton.TabIndex = 47;
            this.customerIdRadioButton.TabStop = true;
            this.customerIdRadioButton.Text = "Customer ID";
            this.customerIdRadioButton.UseVisualStyleBackColor = true;
            this.customerIdRadioButton.CheckedChanged += new System.EventHandler(this.customerIdRadioButton_CheckedChanged);
            // 
            // comboBoxAppointmentType
            // 
            this.comboBoxAppointmentType.FormattingEnabled = true;
            this.comboBoxAppointmentType.Location = new System.Drawing.Point(286, 315);
            this.comboBoxAppointmentType.Name = "comboBoxAppointmentType";
            this.comboBoxAppointmentType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAppointmentType.TabIndex = 48;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAppointmentType);
            this.Controls.Add(this.customerIdRadioButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lblSearchType);
            this.Controls.Add(this.datesRadioButton);
            this.Controls.Add(this.appointmentTypeButton);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.lblAppointmentType);
            this.Controls.Add(this.lblCusomterId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.mainLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentsForm";
            this.Text = "AppointmentsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCusomterId;
        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.RadioButton appointmentTypeButton;
        private System.Windows.Forms.RadioButton datesRadioButton;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton customerIdRadioButton;
        private System.Windows.Forms.ComboBox comboBoxAppointmentType;
    }
}