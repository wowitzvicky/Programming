using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectsOrientedPractics.Model;

namespace ObjectsOrientedPractics.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private static readonly Color ColorSuccess = Color.White;

        private static readonly Color ColorError = Color.LightPink;
        
        private List<Item> _items = new List<Item>();
        
        private Item _currentItem = new Item();
        
        public ItemsTab()
        {
            InitializeComponent();
        }
        
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = CostTextBox.Text;
                var cost = double.Parse(text);

                _currentItem.Cost = cost;
                CostTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                CostTextBox.BackColor = ColorError;
            }
        }
        
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = NameTextBox.Text;
                _currentItem.Name = text;

                NameTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Name = String.Empty;
                NameTextBox.BackColor = ColorError;
            }
        }
        
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = DescriptionTextBox.Text;
                _currentItem.Info = text;

                DescriptionTextBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Info = String.Empty;

                DescriptionTextBox.BackColor = ColorError;
            }
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            _items.Add(_currentItem);
            UpdateItemsListBox();
            ClearAllTextBoxes();
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item);
            }
        }
        
        private void ClearAllTextBoxes()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            UpdateItemsListBox();
            ClearAllTextBoxes();
            _currentItem = new Item();
        }
    }
}    