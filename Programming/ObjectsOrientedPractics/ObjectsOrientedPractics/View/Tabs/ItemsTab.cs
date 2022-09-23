using System.Collections.Generic;
using System.Windows.Forms;
using ObjectsOrientedPractics.Model;

namespace ObjectsOrientedPractics.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        public ItemsTab()
        {
            InitializeComponent();
        }

    }
}    