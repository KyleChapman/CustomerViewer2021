// No comment header? Kinda gross.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomerViewer
{
    public partial class formCustomerEntry : Form
    {
        private List<Customer> customerList = new List<Customer>();
        private bool isAutomated = false;

        public formCustomerEntry()
        {
            InitializeComponent();
        }

        #region "Event Handlers"

        /// <summary>
        /// When the form loads, instantiate some customers and add them to a list so they can be viewed later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            // Declare and instantiate five new customer objects.
            // You are going to be asked to change some of these values.
            Customer kyle = new Customer("Mr.", "Kyle", "Chapman", true);
            // yourNameHere -> make this one YOU
            Customer yourNameHere = new Customer("", "Kyle", "Chapman", true);
            // someoneElse -> make this one... someone who is visible in class today
            Customer someoneElse = new Customer("Sir", "Kamrin", "Aubin", true);
            // fourthPerson -> lead singer of your favourite band
            Customer fourthPerson = new Customer("", "Mark Oliver", "Everett", true);
            // everyoneIsImportant -> whatever
            Customer everyoneIsImportant = new Customer("Lady", "Scape", "Goat", false);
            Customer sixthCustomer = new Customer("Lucky", "Number", "Six", true);

            // Add all of the new customer objects from above to the list.
            customerList.Add(kyle);
            customerList.Add(yourNameHere);
            customerList.Add(someoneElse);
            customerList.Add(fourthPerson);
            customerList.Add(everyoneIsImportant);
            customerList.Add(sixthCustomer);

            AddToListView(kyle);
            AddToListView(yourNameHere);
            AddToListView(someoneElse);
            AddToListView(fourthPerson);
            AddToListView(everyoneIsImportant);
            AddToListView(sixthCustomer);
        }

        /// <summary>
        /// Validate all input fields, and if they are valid create the customer object, add the entered customer to the list, and add them to the ListView.
        /// </summary>
        private void ButtonEnterClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Reset the form to its default state.
        /// </summary>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Me close form.
        /// </summary>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When a worker in the ListView is selected, write that worker's properties into the input controls.
        /// </summary>
        private void WorkerSelected(object sender, EventArgs e)
        {
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {
                comboBoxTitle.Text = listViewEntries.FocusedItem.SubItems[1].Text;
                textBoxFirstName.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxLastName.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                checkBoxVip.Checked = listViewEntries.FocusedItem.Checked;
            }
        }

        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }

        #endregion
        #region "Functions"

        /// <summary>
        /// Converts the customer passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="newCustomer"></param>
        private void AddToListView(Customer newCustomer)
        {
            // Declare and instantiate a new ListViewItem.
            ListViewItem customerItem = new ListViewItem();

            isAutomated = true;
            customerItem.Checked = newCustomer.VipStatus;
            
            customerItem.SubItems.Add(newCustomer.Title);
            customerItem.SubItems.Add(newCustomer.FirstName);
            customerItem.SubItems.Add(newCustomer.LastName);

            // Add the customerItem to the ListView.
            listViewEntries.Items.Add(customerItem);
            
            isAutomated = false;
        }

        /// <summary>
        /// Reset the form's input fields to their default states.
        /// </summary>
        private void SetDefaults()
        {
            // Resets fields to default state.
            comboBoxTitle.SelectedIndex = -1;
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            checkBoxVip.Checked = false;

            // Set a default focus.
            comboBoxTitle.Focus();
        }

        /// <summary>
        /// Checks whether the input related to a worker is valid
        /// </summary>
        /// <param name="title">The customer's title as a string</param>
        /// <param name="firstName">The customer's first name as a string</param>
        /// <param name="lastName">The customer's last name as a string</param>
        /// <returns></returns>
        private bool IsWorkerValid(string title, string firstName, string lastName)
        {
            bool isValid = true;

            // Check the first input.
            // If it's not valid, set isValid = false and write an error message.
            // Check the second input.
            // If it's not valid, set isValid = false and write an error message.
            // Check the third input.
            // If it's not valid, set isValid = false and write an error message.

            return isValid;
        }

        #endregion

    }
}
