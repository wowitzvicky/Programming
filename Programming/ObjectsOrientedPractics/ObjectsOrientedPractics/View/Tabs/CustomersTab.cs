using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectsOrientedPractics.Model;

namespace ObjectsOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private static readonly Color ColorSuccess = Color.White;
        private static readonly Color ColorError = Color.LightPink;

        private Customer _currentCustomer;

        public List<Customer> Customers { get; set; } = new List<Customer>();

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = CustomerNameTextBox.Text;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer) CustomersListBox.SelectedItem;
            _currentCustomer = selectedCustomer;
            PrintCustomersTextBox();
        }

        private void PrintCustomersTextBox()
        {
            CustomerIdTextBox.Text = "" + _currentCustomer.Id;
            CustomerNameTextBox.Text = "" + _currentCustomer.Fullname;
            addressControl.Address = _currentCustomer.Address;
        }
        
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _currentCustomer.Fullname = $"{nameof(Customer)} {_currentCustomer.Id}";
            Customers.Add(_currentCustomer);
            UpdateCustomersListbox();
            ClearAllTextBoxes();
        }

        private void UpdateCustomersListbox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomersListBox.Items.Add(customer);
            }
        }

        private void ClearAllTextBoxes()
        {
            CustomerIdTextBox.Clear();
            CustomerNameTextBox.Clear();
            addressControl.Clear();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            Customers.Remove(_currentCustomer);
            UpdateCustomersListbox();
            ClearAllTextBoxes();
            _currentCustomer = new Customer();
        }

        private void CustomerNameTextBox_Leave(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            CustomersListBox.Items.RemoveAt(index);
            CustomersListBox.Items.Insert(index, CustomerNameTextBox.Text);
            CustomersListBox.SelectedIndex = index;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomersTab
            // 
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(125, 95);
            this.ResumeLayout(false);

        }
    }
}