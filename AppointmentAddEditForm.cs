using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C868_Richard_Menz
{
    public partial class AppointmentAddEditForm : Form
    {
        private AppointmentsForm PreviousForm;
        private int SelectedAppointmentID = -1;

        public AppointmentAddEditForm(AppointmentsForm prevForm, int appointmentId)
        {
            InitializeComponent();
            PreviousForm = prevForm;
            SelectedAppointmentID = appointmentId;
        }

        public AppointmentAddEditForm(AppointmentsForm prevForm)
        {
            InitializeComponent();
            PreviousForm = prevForm;
        }

        private void AppointmentAddEditForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> customerDictionary = MainScreen.ListOfCustomers.ToDictionary(list => list.CustomerId, list => list.CustomerName);
            customerComboBox.DataSource = new BindingSource(customerDictionary, null);
            customerComboBox.DisplayMember = "Value";
            customerComboBox.ValueMember = "Key";
            customerComboBox.SelectedItem = null;

            typeComboBox.DataSource = new[] { "Scrum", "Presentation", "Lunch", "Interview", "Consultation" };
            typeComboBox.SelectedItem = null;
            
            if (SelectedAppointmentID >= 0)
            {
                titleLabel.Text = "Edit Appointment";
                Appointment appointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == SelectedAppointmentID).Single();
                idTextBox.Text = appointment.AppointmentId.ToString();
                customerComboBox.Text = customerDictionary[appointment.CustomerId];
                typeComboBox.Text = appointment.Type;
                startDateTimePicker.Value = appointment.Start;
                endDateTimePicker.Value = appointment.End;
            }
            else
            {
                DateTime now = DateTime.Now;
                startDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
                endDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
                TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;
                int selectedCustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
                if (typeComboBox.SelectedValue == null)
                {
                    throw new ApplicationException("Enter a value into type box");
                }
                string selectedType = typeComboBox.SelectedValue.ToString();
                DateTime selectedStart = startDateTimePicker.Value;
                DateTime selectedEnd = endDateTimePicker.Value;
                bool overlaping = false;

                foreach (var appt in MainScreen.ListOfAppointments)
                {
                    if(appt.Start <= selectedStart && appt.End > selectedStart && SelectedAppointmentID != appt.AppointmentId) //&& (!(SelectedAppointmentID >= 0)) || SelectedAppointmentID >= 0)
                    {
                        overlaping = true;
                    }

                    if (selectedStart <= appt.Start && selectedEnd > appt.Start && SelectedAppointmentID != appt.AppointmentId) //&& (!(SelectedAppointmentID >= 0)) || SelectedAppointmentID >= 0)
                    {
                        overlaping = true;
                    }
                }

                if (selectedCustomerId < 1)
                {
                    throw new ApplicationException("A customer must be selected.");
                }

                if (selectedStart > selectedEnd)
                {
                    throw new ApplicationException("The end time cannot be before the start time.");
                }

                if ((selectedStart.TimeOfDay < businessStart) || (selectedStart.TimeOfDay > businessEnd) || (selectedEnd.TimeOfDay < businessStart) || (selectedEnd.TimeOfDay > businessEnd))
                {
                    throw new ApplicationException("You cannot schedule an appointment outside of business hours, 8 am - 5 pm");
                }

                if (overlaping)
                {
                    throw new ApplicationException("You cannnot overlap appointments");
                }

                if (SelectedAppointmentID >= 0)
                {
                    Appointment appointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == SelectedAppointmentID).Single();
                    Database.updateAppointment(appointment, selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                else
                {
                    Database.addAppointment(selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You must select an appointment Type.", "Instructions", MessageBoxButtons.OK);
            }
            catch (ApplicationException err)
            {
                MessageBox.Show(err.Message, "Instructions", MessageBoxButtons.OK);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void AppointmentAddEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.UpdateSelection();
            PreviousForm.Show();
        }

        private void customerComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void typeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
