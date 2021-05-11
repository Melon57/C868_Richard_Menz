
namespace C868_Richard_Menz
{
    partial class ReportsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTypeMonthReport = new System.Windows.Forms.RadioButton();
            this.radioButtonSchduleConsultantReport = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekAppointmentsReport = new System.Windows.Forms.RadioButton();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Report to Display";
            // 
            // radioButtonTypeMonthReport
            // 
            this.radioButtonTypeMonthReport.AutoSize = true;
            this.radioButtonTypeMonthReport.Location = new System.Drawing.Point(10, 71);
            this.radioButtonTypeMonthReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTypeMonthReport.Name = "radioButtonTypeMonthReport";
            this.radioButtonTypeMonthReport.Size = new System.Drawing.Size(215, 17);
            this.radioButtonTypeMonthReport.TabIndex = 1;
            this.radioButtonTypeMonthReport.Text = "Number of Appointment Types by Month";
            this.radioButtonTypeMonthReport.UseVisualStyleBackColor = true;
            this.radioButtonTypeMonthReport.CheckedChanged += new System.EventHandler(this.radioButtonTypeMonthReport_CheckedChanged);
            // 
            // radioButtonSchduleConsultantReport
            // 
            this.radioButtonSchduleConsultantReport.AutoSize = true;
            this.radioButtonSchduleConsultantReport.Location = new System.Drawing.Point(234, 71);
            this.radioButtonSchduleConsultantReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonSchduleConsultantReport.Name = "radioButtonSchduleConsultantReport";
            this.radioButtonSchduleConsultantReport.Size = new System.Drawing.Size(137, 17);
            this.radioButtonSchduleConsultantReport.TabIndex = 2;
            this.radioButtonSchduleConsultantReport.Text = "Schedule by Consultant";
            this.radioButtonSchduleConsultantReport.UseVisualStyleBackColor = true;
            this.radioButtonSchduleConsultantReport.CheckedChanged += new System.EventHandler(this.radioButtonSchduleConsultantReport_CheckedChanged);
            // 
            // radioButtonWeekAppointmentsReport
            // 
            this.radioButtonWeekAppointmentsReport.AutoSize = true;
            this.radioButtonWeekAppointmentsReport.Location = new System.Drawing.Point(380, 71);
            this.radioButtonWeekAppointmentsReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWeekAppointmentsReport.Name = "radioButtonWeekAppointmentsReport";
            this.radioButtonWeekAppointmentsReport.Size = new System.Drawing.Size(214, 17);
            this.radioButtonWeekAppointmentsReport.TabIndex = 3;
            this.radioButtonWeekAppointmentsReport.Text = "Customers with Appointments this Week";
            this.radioButtonWeekAppointmentsReport.UseVisualStyleBackColor = true;
            this.radioButtonWeekAppointmentsReport.CheckedChanged += new System.EventHandler(this.radioButtonWeekAppointmentsReport_CheckedChanged);
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(10, 117);
            this.reportTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(581, 289);
            this.reportTextBox.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(194, 419);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(211, 44);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 474);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.radioButtonWeekAppointmentsReport);
            this.Controls.Add(this.radioButtonSchduleConsultantReport);
            this.Controls.Add(this.radioButtonTypeMonthReport);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTypeMonthReport;
        private System.Windows.Forms.RadioButton radioButtonSchduleConsultantReport;
        private System.Windows.Forms.RadioButton radioButtonWeekAppointmentsReport;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}