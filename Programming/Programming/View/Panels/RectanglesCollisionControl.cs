using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Properties;
using Collision = Programming.Model.Classes.CollisionManager;
using Rectangle = Programming.Model.Classes.Rectangle;
using Rnd = Programming.Model.Geometry.RectangleFactory;
using Point2D = Programming.Model.Classes.Point2D;
using AppColor = Programming.Model.Classes.AppColor;

namespace Programming.View.Panels
{
    /// <summary>
    /// Рисует прямоугольники и проверяет их на пересечение.
    /// </summary>
	public partial class RectanglesCollisionControl : UserControl
	{
        /// <summary>
        /// Хранит данные о текущем прямоугольнике.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();
        
        /// <summary>
        /// Список прямоугольников на рисунке.
        /// </summary>
		private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();
        
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectangleButton.Image = Resources.rectangle_add_24x24;
        }

        private void RemoveRectangleButton_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveRectangleButton.Image = Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Resources.rectangle_add_24x24_uncolor;
        }
       
        /// <summary>
        /// Находит пересечения прямоугольников.
        /// </summary>
        private void FindCollisions()
        {
            if (_rectanglePanels.Count == 0)
            {
            }
            else
            {
                CanvasPanel.Controls.Clear();
                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    _rectanglePanels[i].BackColor = AppColor.Green;
                }
                
                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    for (int j = 0; j < _rectanglePanels.Count; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (Collision.IsCollision(_rectangles[i], _rectangles[j]))
                        {
                                _rectanglePanels[i].BackColor = 
                                    _rectanglePanels[j].BackColor = AppColor.Red;
                        }
                    }
                }

                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    CanvasPanel.Controls.Add(_rectanglePanels[i]);
                }
            }
        }

        /// <summary>
        /// Получает информацию о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает строку с информацией о прямоугольнике.</returns>
        private string GetRectangleInfo(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X = {rectangle.Center.X}; " +
                   $"Y = {rectangle.Center.Y}; " +
                   $"W = {rectangle.Width}; " +
                   $"H = {rectangle.Length})";
        }
        
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            int index = _rectangles.Count;
            
            if (index == 0)
			{
                _currentRectangle = Rnd.Randomize();
			}
            else _currentRectangle = Rnd.Randomize();
            Panel panel = new Panel();
            panel.Location = new Point(Convert.ToInt32(_currentRectangle.Center.X),
                Convert.ToInt32(_currentRectangle.Center.Y));
            panel.Height = Convert.ToInt32(_currentRectangle.Length);
            panel.Width = Convert.ToInt32(_currentRectangle.Width);
            _rectanglePanels.Add(panel);
            _rectangles.Add(_currentRectangle);
            FindCollisions();
            CanvasPanel.Controls.Add(panel);
            RectangleCoordinatesListBox.Items.Add(GetRectangleInfo(_currentRectangle));
           RectangleCoordinatesListBox.SelectedIndex = index;
        }
        
        /// <summary>
        /// Очищает информацию о прямоугольнике.
        /// </summary>
        void ClearRectangleInfo()
        {
            RectangleIdTextBox.Text = "";
            RectangleXTextBox.Text = "";
            RectangleYTextBox.Text = "";
            RectangleHeightTextBox.Text = "";
            RectangleWidthTextBox.Text = "";
        }
        
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int i = RectangleCoordinatesListBox.SelectedIndex;
                _rectangles.RemoveAt(i);
                RectangleCoordinatesListBox.Items.RemoveAt(i);
                CanvasPanel.Controls.RemoveAt(i);
                _rectanglePanels.RemoveAt(i);

                if (_rectangles.Count == 0)
                {
                    ClearRectangleInfo();
                }
                else
                {
                    FindCollisions();
                    RectangleCoordinatesListBox.SelectedIndex = RectangleCoordinatesListBox.Items.Count - 1;
                }
            }
        }
        
        /// <summary>
        /// Обновляет информацию о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectangleIdTextBox.Text = "" + rectangle.Id;
            RectangleXTextBox.Text = "" + rectangle.Center.X;
            RectangleYTextBox.Text = "" + rectangle.Center.Y;
            RectangleHeightTextBox.Text = "" + rectangle.Length;
            RectangleWidthTextBox.Text = "" + rectangle.Width;
        }
        
        private void RectangleCoordinatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleCoordinatesListBox.SelectedIndex != -1)
            {
                UpdateRectangleInfo(_rectangles[RectangleCoordinatesListBox.SelectedIndex]);
            }
        }

        private void PrintRectanglesCoordinatesList(int index)
        {
            RectangleCoordinatesListBox.Items.Clear();
            for (int j = 0; j < _rectangles.Count; j++)
                RectangleCoordinatesListBox.Items.Add(GetRectangleInfo(_rectangles[j]));
            RectangleCoordinatesListBox.SelectedIndex = index;
        }

        private void RectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectangleCoordinatesListBox.SelectedIndex;
            if (index == -1)
            {
            }
            else if (RectangleXTextBox.Text != "")
                if(_rectangles[index].Center.X != Convert.ToDouble(RectangleXTextBox.Text)) 
                { 
                    Point2D center = new Point2D(Convert.ToDouble(RectangleXTextBox.Text),
                    _rectangles[index].Center.Y); 
                    _rectangles[index].Center = center; 
                    _rectanglePanels[index].Location = new Point(Convert.ToInt32(_rectangles[index].Center.X), 
                        Convert.ToInt32(_rectangles[index].Center.Y)); 
                    PrintRectanglesCoordinatesList(index); 
                    FindCollisions(); 
                }
        }

        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectangleCoordinatesListBox.SelectedIndex;
            if (index == -1)
            {
            }
            else if (RectangleYTextBox.Text != "")
                if(_rectangles[index].Center.Y != Convert.ToDouble(RectangleYTextBox.Text)) 
                { 
                    Point2D center = new Point2D(_rectangles[index].Center.X,
                    Convert.ToDouble(RectangleYTextBox.Text));
                
                    _rectangles[index].Center = center; 
                    _rectanglePanels[index].Location = new Point(Convert.ToInt32(_rectangles[index].Center.X), 
                        Convert.ToInt32(_rectangles[index].Center.Y)); 
                    PrintRectanglesCoordinatesList(index); 
                    FindCollisions();
                }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectangleCoordinatesListBox.SelectedIndex;
            if (index == -1)
            {
            }
            else if (RectangleWidthTextBox.Text != "")
                if (_rectangles[index].Width != Convert.ToDouble(RectangleWidthTextBox.Text)) 
                { 
                    _rectangles[index].Width = Convert.ToDouble(RectangleWidthTextBox.Text); 
                    _rectanglePanels[index].Width = Convert.ToInt32(RectangleWidthTextBox.Text); 
                    
                    PrintRectanglesCoordinatesList(index); 
                    FindCollisions();
                }
        }
        
        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectangleCoordinatesListBox.SelectedIndex;
            if (index == -1)
            {
            }
            else if (RectangleHeightTextBox.Text != "")
                if (_rectangles[index].Length != Convert.ToDouble(RectangleHeightTextBox.Text)) 
                { 
                    _rectangles[index].Length = Convert.ToDouble(RectangleHeightTextBox.Text); 
                    _rectanglePanels[index].Height = Convert.ToInt32(RectangleHeightTextBox.Text);
                    
                    PrintRectanglesCoordinatesList(index); 
                    FindCollisions(); 
                }
        }
    }
}
