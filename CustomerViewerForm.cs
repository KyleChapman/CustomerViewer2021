// Last Modified By:    Kyle Chapman (or your name here)
// Original Date:       March 1, 2021
// Last Modified Date:  March 1, 2021
// Project Name:        CustomerViewer
// Description:
//  Using the existing Customer class, this is a simple form designed to toggle
// through a list of customers, strictly to view their info.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerViewer
{
    public partial class formCustomerViewer : Form
    {
        // Declare a collection of all customers as a List.
        private List<Customer> customerList = new List<Customer>();
        // An index representing the current selected customer.
        private int currentIndex = 4;

        // Minimum and maximum indexes; should match the number of records set up below.
        private const int MinimumIndex = 0;
        private const int MaximumIndex = 4;

        public formCustomerViewer()
        {
            InitializeComponent();
        }

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
            Customer yourNameHere = new Customer("", "", "", true);
            Customer someoneElse = new Customer("", "", "", true);
            Customer fourthPerson = new Customer();
            Customer everyoneIsImportant = new Customer("", "", "", false);

            // Add all of the new customer objects from above to the list.
            customerList.Add(kyle);
            customerList.Add(yourNameHere);
            customerList.Add(someoneElse);
            customerList.Add(fourthPerson);
            customerList.Add(everyoneIsImportant);

            // Call ViewCustomer and display the first customer object.
            ViewCustomer(currentIndex);
        }

        /// <summary>
        /// Shows the previous customer in the list, populating all fields with information related to the previous customer; displays an error message if there are no prior customers in the list
        /// </summary>
        private void PreviousButton(object sender, EventArgs e)
        {
            // Go to the previous customer in the list.
            currentIndex -= 1;

            // If we can view their info, that's great.
            // If we can't view their info then we are at the start of the list.
            if (!ViewCustomer(currentIndex))
            {
                // Since we're at the start of the list, don't go back further
                // and disable the Previous button.
                currentIndex = 0;
                buttonPrevious.Enabled = false;
            }

            // We know we're not at the end of the list, so allow the Next button.
            buttonNext.Enabled = true;
        }

        private void NextButton(object sender, EventArgs e)
        {

        }

        private void FirstButton(object sender, EventArgs e)
        {

        }

        private void LastButton(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Me close form.
        /// </summary>
        private void ExitButton(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Attempt to display a customer from the customerList with a key value matching the argument passed in.
        /// </summary>
        /// <param name="listIndex">An integer value representing the index of the customer object</param>
        /// <returns>true if successful, false if not</returns>
        private bool ViewCustomer(int listIndex)
        {
            // If the current listIndex is in range...
            if (listIndex >= MinimumIndex && listIndex <= MaximumIndex)
            {
                // Populate the various fields with the relevant customer info.
                textBoxIdentificationNumber.Text = customerList[listIndex].Id.ToString();
                comboBoxTitle.Text = customerList[listIndex].Title;
                textBoxFirstName.Text = customerList[listIndex].FirstName;
                textBoxLastName.Text = customerList[listIndex].LastName;
                checkBoxVip.Checked = customerList[listIndex].VipStatus;

                // This was successful!
                return true;
            }
            else
            {
                // We went out of bounds; this was not successful.
                return false;
            }
        }
    }
}
