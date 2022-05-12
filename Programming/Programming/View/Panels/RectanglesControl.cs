using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rnd = Programming.Model.Geometry.RectangleFactory;
using Rectangle = Programming.Model.Classes.Rectangle;
using AppColor = Programming.Model.Classes.AppColor;

namespace Programming.View.Panels
{
	public partial class RectanglesControl : UserControl
	{
        private Rectangle _currentRectangle = new Rectangle();
        
		private List<Rectangle> _rectangles = new List<Rectangle>();
        
		public RectanglesControl()
		{
			InitializeComponent();
			for (int i = 0; i < 5; i++)
			{
				_rectangles.Add(Rnd.Randomize());
				RectanglesListBox.Items.Add(_rectangles[i]);
			}
            _currentRectangle = _rectangles[0];
        }

		private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			PrintRectanglesTextBox();
			PrintCoordinatesTextBox();
			PrintIdTextBox();
		}
        
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = AppColor.CorrectBackColor;
            }
            catch
            {
                LengthTextBox.BackColor = AppColor.ErrorBackColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColor.CorrectBackColor;
            }
            catch
            {
                WidthTextBox.BackColor = AppColor.ErrorBackColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }
        
        private int FindRectangleWithMaxWidth()
        {
            double max = 0;
            int currentIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                RectanglesListBox.SelectedIndex = i;
                if (RectanglesListBox.SelectedItem is Rectangle temp)
                {
                    if (temp.Width > max)
                    {
                        max = temp.Width;
                        currentIndex = i;
                    }
                }
            }
            return currentIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void PrintRectanglesTextBox()
        {
            if (RectanglesListBox.SelectedItem is Rectangle temp)
            {
                _currentRectangle = temp;
                LengthTextBox.Text = "" + _currentRectangle.Length;
                WidthTextBox.Text = "" + _currentRectangle.Width;
                ColorTextBox.Text = "" + _currentRectangle.Color;
            }
        }
        
        private void PrintCoordinatesTextBox()
        {
            if (RectanglesListBox.SelectedItem is Rectangle temp)
            {
                _currentRectangle = temp;
                XTextBox.Text = "" + _currentRectangle.Center.X;
                YTextBox.Text = "" + _currentRectangle.Center.Y;
            }
        }

        private void PrintIdTextBox()
        {
            if (RectanglesListBox.SelectedItem is Rectangle temp)
            {
                _currentRectangle = temp;
                IdTextBox.Text = "" + _currentRectangle.Id;
            }
        }
    }
}
