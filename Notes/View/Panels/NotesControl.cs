using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.Model;
using Note = Notes.Model.Classes.Note;
using Notes.Resources;
namespace Notes.View.Panels
{
	public partial class NotesControl : UserControl
	{
		public NotesControl()
		{
			InitializeComponent();
			NoteCategoryComboBox.Items.Add(Category.Home);
			NoteCategoryComboBox.Items.Add(Category.Job);
			NoteCategoryComboBox.Items.Add(Category.Sport);
			NoteCategoryComboBox.Items.Add(Category.Finance);
		}

		private Note _currentNote = new Note();

		private List<Note> _notes = new List<Note>();

		private string GetNoteInfo(Note note)
		{
			return $"{note.Name} ";
		}
		private void SortNotes()
		{
			Note temp;
			for (int i = 1; i < _notes.Count; i++)
			{
				for (int j = 0; j < _notes.Count - 1; j++)
				{
					if (_notes[j]._addTime < _notes[j + 1]._addTime)
					{
						temp = _notes[j];
						_notes[j] = _notes[j + 1];
						_notes[j + 1] = temp;
					}
				}
			}
		}
		private void PrintNotesList()
		{
			NotesListBox.Items.Clear();
			SortNotes();
			for (int i = 0; i < _notes.Count; i++)
			{
				NotesListBox.Items.Add(GetNoteInfo(_notes[i]));
			}
		}

		private void UpdateNoteInfo(Note note)
		{
			NameOfNoteTextBox.Text = "" + note.Name;
			TextOfNoteRichTextBox.Text = "" + note.Text;
			DateLabel.Text = "Время создания : " + note._addTime;
			NoteCategoryComboBox.Text = note._category;
		}

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
			Note note = new Note(NameOfNoteTextBox.Text, TextOfNoteRichTextBox.Text,NoteCategoryComboBox.Text);
			_currentNote = note;
			_notes.Add(_currentNote);
			PrintNotesList();
			ClearNoteInfo();
		}

		private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NotesListBox.SelectedIndex != -1)
			{
				UpdateNoteInfo(_notes[NotesListBox.SelectedIndex]);
			}
		}

		private void DeleteNoteButton_Click(object sender, EventArgs e)
		{
			if (_notes.Count > 0 && NotesListBox.SelectedIndex != -1)
			{
				int i = NotesListBox.SelectedIndex;
				_notes.RemoveAt(i);
				NotesListBox.Items.RemoveAt(i);
				ClearNoteInfo();
			}
		}

		private void ChangePushButton_Click(object sender, EventArgs e)
		{
			if (NotesListBox.SelectedIndex != -1)
			{
				int id = _notes[NotesListBox.SelectedIndex].Id;
				Note note = new Note(id,NameOfNoteTextBox.Text, TextOfNoteRichTextBox.Text);
				_currentNote = note;
				_notes[NotesListBox.SelectedIndex] = _currentNote;
				UpdateNoteInfo(_currentNote);
				PrintNotesList();
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

		private void ChangePushButton_MouseDown(object sender, MouseEventArgs e)
		{
			ChangePushButton.Image = Resource.Note_Change_Color;
		}

		private void ChangePushButton_MouseLeave(object sender, EventArgs e)
		{
			ChangePushButton.Image = Resource.Note_Change_Uncolor;
		}

		private void DeleteNoteButton_MouseMove(object sender, MouseEventArgs e)
		{
			DeleteNoteButton.Image = Resource.Note_Remove_Color;
		}

		private void DeleteNoteButton_MouseLeave(object sender, EventArgs e)
		{
			DeleteNoteButton.Image = Resource.Note_Remove_Uncolor;
		}

		private void ChangePushButton_MouseMove(object sender, MouseEventArgs e)
		{
			ChangePushButton.Image = Resource.Note_Change_Color;
		}
	}
}
