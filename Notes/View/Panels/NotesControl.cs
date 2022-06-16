using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Notes.Model;
using Note = Notes.Model.Classes.Note;
using Notes.Resources;
using Notes.Model.Enums;
using Notes.Model.Classes;

namespace Notes.View.Panels
{
	public partial class NotesControl : UserControl
	{
		private static bool to_change = false;

		ProjectSerializer Serializer = new ProjectSerializer();

		public NotesControl()
		{
			InitializeComponent();
			Properties.Settings.Default.DPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
			                                    "/Nepsha/NoteApp/";
			Properties.Settings.Default.Save();
			Serializer.Filename = Properties.Settings.Default.DPath;
			if (!Directory.Exists(Serializer.Filename))
			{
				Directory.CreateDirectory(Serializer.Filename);
			}

			Serializer.Filename += "save.json";
			_notes = Serializer.LoadFromFile();
			PrintNotesList();
			NoteCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
		}

		/// <summary>
		/// Хранит данные о текущей заметке.
		/// </summary>
		private Note _currentNote = new Note();

		/// <summary>
		/// Список заметок.
		/// </summary>
		private List<Note> _notes = new List<Note>();

		/// <summary>
		/// Строковый вывод информации о заметке.
		/// </summary>
		/// <param name="note">Экземпляр класса <see cref="Note"></see></param>
		/// <returns>Возвращает строковое представление о заметке.</returns>
		private string GetNoteInfo(Note note)
		{
			return $"{note.Name}";
		}

		/// <summary>
		/// Сортирует список заметок.
		/// </summary>
		private void SortNotes()
		{
			Note temp;
			for (int i = 1; i < _notes.Count; i++)
			{
				for (int j = 0; j < _notes.Count - 1; j++)
				{
					if (_notes[j].AddTime < _notes[j + 1].AddTime)
					{
						temp = _notes[j];
						_notes[j] = _notes[j + 1];
						_notes[j + 1] = temp;
					}
				}
			}
		}

		/// <summary>
		/// Выводит список заметок.
		/// </summary>
		private void PrintNotesList()
		{
			if (_notes.Count != 0)
			{
				NotesListBox.Items.Clear();
				SortNotes();
				for (int i = 0; i < _notes.Count; i++)
				{
					NotesListBox.Items.Add(GetNoteInfo(_notes[i]));
				}

				NotesListBox.SelectedIndex = 0;
				Serializer.SaveToFile(_notes);
			}
		}

		/// <summary>
		/// Обновляет информацию о выбранной заметке.
		/// </summary>
		/// <param name="note">Заметка.</param>
		private void UpdateNoteInfo(Note note)
		{
			NameOfNoteTextBox.Text = "" + note.Name;
			TextOfNoteRichTextBox.Text = "" + note.Text;
			DateLabel.Text = "Время создания: " + note.AddTime;
			NoteCategoryComboBox.Text = note.NoteCategory;
		}

		/// <summary>
		/// Очищает вывод информации о заметке.
		/// </summary>
		private void ClearNoteInfo()
		{
			NameOfNoteTextBox.Text = "";
			TextOfNoteRichTextBox.Text = "";
			DateLabel.Text = "";
			NoteCategoryComboBox.Text = "";
		}

		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			int index = _notes.Count;

			if (index == 0)
			{

			}

			string name = NameOfNoteTextBox.Text;
			if (name == "")
			{
				name = "Без названия";
			}

			Note note = new Note(name, TextOfNoteRichTextBox.Text, NoteCategoryComboBox.Text);
			_currentNote = note;
			_notes.Add(_currentNote);
			PrintNotesList();
			ClearNoteInfo();
			NotesListBox.SelectedIndex = -1;
		}

		private void TurnOnChanges()
		{
			this.TextOfNoteRichTextBox.TextChanged += this.TextOfNoteRichTextBox_TextChanged;
			this.NoteCategoryComboBox.SelectedValueChanged += this.NoteCategoryComboBox_SelectedValueChanged;
			this.NameOfNoteTextBox.TextChanged += this.NameOfNoteTextBox_TextChanged;
		}

		private void TurnOffChanges()
		{
			this.TextOfNoteRichTextBox.TextChanged -= this.TextOfNoteRichTextBox_TextChanged;
			this.NoteCategoryComboBox.SelectedValueChanged -= this.NoteCategoryComboBox_SelectedValueChanged;
			this.NameOfNoteTextBox.TextChanged -= this.NameOfNoteTextBox_TextChanged;
		}

		private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NotesListBox.SelectedIndex != -1)
			{
				TurnOffChanges();
				UpdateNoteInfo(_notes[NotesListBox.SelectedIndex]);
				TurnOnChanges();
			}
		}

		private void DeleteNoteButton_Click(object sender, EventArgs e)
		{
			if (_notes.Count > 0 && NotesListBox.SelectedIndex != -1)
			{
				int i = NotesListBox.SelectedIndex;
				_notes.RemoveAt(i);
				NotesListBox.Items.RemoveAt(i);
				Serializer.SaveToFile(_notes);
				ClearNoteInfo();
			}
		}

		private void AddNoteButton_MouseMove(object sender, MouseEventArgs e)
		{
			AddNoteButton.Image = Resource.Note_Add_Color24x24;
		}

		private void AddNoteButton_MouseLeave(object sender, EventArgs e)
		{
			AddNoteButton.Image = Resource.Note_Add_Uncolor;
		}

		private void DeleteNoteButton_MouseMove(object sender, MouseEventArgs e)
		{
			DeleteNoteButton.Image = Resource.Note_Remove_Color;
		}

		private void DeleteNoteButton_MouseLeave(object sender, EventArgs e)
		{
			DeleteNoteButton.Image = Resource.Note_Remove_Uncolor;
		}

		private void NameOfNoteTextBox_TextChanged(object sender, EventArgs e)
		{
			int index = NotesListBox.SelectedIndex;
			if (index == -1)
			{
				return;
			}
			else if (NameOfNoteTextBox.Text != "")
			{
				if (_notes[index].Text != NameOfNoteTextBox.Text)
				{
					int id = _notes[NotesListBox.SelectedIndex].Id;
					Note note = new Note(id, NameOfNoteTextBox.Text, _notes[index].Text, _notes[index].Category);
					_currentNote = note;
					_notes[index] = _currentNote;
					UpdateNoteInfo(_currentNote);
					PrintNotesList();
				}
			}
		}

		private void NoteCategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			int index = NotesListBox.SelectedIndex;
			if (index == -1)
			{
				return;
			}
			else if (NoteCategoryComboBox.Text != "")
			{
				if (_notes[index].Category != NoteCategoryComboBox.Text)
				{
					int id = _notes[NotesListBox.SelectedIndex].Id;
					Note note = new Note(id, _notes[index].Name, _notes[index].Text, NoteCategoryComboBox.Text);
					_currentNote = note;
					_notes[index] = _currentNote;
					UpdateNoteInfo(_currentNote);
					PrintNotesList();
				}
			}
		}

		private void TextOfNoteRichTextBox_TextChanged(object sender, EventArgs e)
		{
			int index = NotesListBox.SelectedIndex;
			if (index == -1)
			{
				return;
			}
			else if (TextOfNoteRichTextBox.Text != "")
			{
				if (_notes[index].Category != TextOfNoteRichTextBox.Text)
				{
					int id = _notes[NotesListBox.SelectedIndex].Id;
					Note note = new Note(id, _notes[index].Name, TextOfNoteRichTextBox.Text, _notes[index].Category);
					_currentNote = note;
					_notes[index] = _currentNote;
					UpdateNoteInfo(_currentNote);
					PrintNotesList();
				}
			}
		}

		private void NotesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			NotesListBox.SelectedIndex = -1;
		}
	}
}