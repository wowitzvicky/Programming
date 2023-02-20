using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectsOrientedPractics.Model;

namespace ObjectsOrientedPractics.View.Tabs
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

            Item[] items = new Item[5];
            
            for(int i = 0; i < 5; i++)
            {
                items[i] = new Item();
                ItemsListBox.Items.Add(items[i]);
            }
            
            CategoryComboBox.Sorted = true;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }
        
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cost = double.Parse(CostTextBox.Text);

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
                _currentItem.Name = NameTextBox.Text;
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
                _currentItem.Info = DescriptionTextBox.Text;

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
            CategoryComboBox.SelectedIndex = -1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            UpdateItemsListBox();
            ClearAllTextBoxes();
        }

        private void PrintItemsTextBox()
        {
            if (ItemsListBox.SelectedItem is Item temp)
            {
                _currentItem = temp;
                NameTextBox.Text = "" + _currentItem.Name;
                CostTextBox.Text = "" + _currentItem.Cost;
                DescriptionTextBox.Text = "" + _currentItem.Info;
                IdTextBox.Text = "" + _currentItem.Id;
                CategoryComboBox.SelectedItem = "" + _currentItem.Category;
            }
        }
        
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintItemsTextBox();
            var selectedItem = (Item) ItemsListBox.SelectedItem;
            _currentItem = selectedItem;
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            ItemsListBox.Items.RemoveAt(index);
            ItemsListBox.Items.Insert(index, NameTextBox.Text);
            ItemsListBox.SelectedIndex = index;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CategoryComboBox.SelectedIndex == -1) return;
                var category = (Category) CategoryComboBox.SelectedItem;
                _currentItem.Category = category;
                CategoryComboBox.BackColor = ColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                CategoryComboBox.BackColor = ColorError;
            }
        }
    }
}    