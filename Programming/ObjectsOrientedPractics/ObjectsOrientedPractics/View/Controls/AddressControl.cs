using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ObjectsOrientedPractics.Model;

namespace ObjectsOrientedPractics.Controls
{
    public partial class AddressControl : UserControl
    {
        private static readonly Color ColorSuccess = Color.White;
        private static readonly Color ColorError = Color.LightPink;

        private Address _address;

        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                UpdateFields();
            }
        }
        
        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }

        private void UpdateFields()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        public void Clear()
        {
            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = PostIndexTextBox.Text;
                if (text == null) return;
                var index = int.Parse(text);
                _address.Index = index;
                PostIndexTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                PostIndexTextBox.BackColor = ColorError;
                _address.Index = 0;
            }
        }
        
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = CountryTextBox.Text;
                if (text == null) return;
                _address.Country = text;
                CountryTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                CountryTextBox.BackColor = ColorError;
                _address.Country = String.Empty;
            }
        }
        
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = CityTextBox.Text;
                if (text == null) return;
                _address.City = text;
                CityTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                CityTextBox.BackColor = ColorError;
                _address.City = String.Empty;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = StreetTextBox.Text;
                if (text == null) return;
                _address.Street = text;
                StreetTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                StreetTextBox.BackColor = ColorError;
                _address.Street = String.Empty;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = BuildingTextBox.Text;
                if (text == null) return;
                _address.Building = text;
                BuildingTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                BuildingTextBox.BackColor = ColorError;
                _address.Building = String.Empty;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = ApartmentTextBox.Text;
                if (text == null) return;
                _address.Apartment = text;
                ApartmentTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                ApartmentTextBox.BackColor = ColorError;
                _address.Apartment = String.Empty;
            }
        }
    }
}