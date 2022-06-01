using System;
using Notes.Model;
namespace Notes.Model.Classes
{
	public class Note
	{
		public static int _allNotesCount=0;

		public int Id { get; set; }

		public string _name { get; set; }

		public string _text { get; set; }

		public string _category { get; set; }
		
		readonly public DateTime  _addTime;

		
		public static int AllNotesCount
		{
			get
			{
				return _allNotesCount;

			}
			private set
			{
				_allNotesCount = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			private set
			{
				Validator.AssertValueInRange(_name);
				_name = value;
			}
		}

		public string Text
		{
			get
			{
				return _text;
			}
			private set
			{
				_text = value;
			}
		}

		public string Category
		{
			get
			{
				return _category;
			}
			private set
			{
				_text = value;
			}
		}
		public Note()
		{

		}

		public Note(string name, string text,string category)
		{
			AllNotesCount++;
			Id = AllNotesCount;
			_name = name;
			_text = text;
			_category = category;
			_addTime = DateTime.Now;
		}
		public Note(int id,string name, string text)
		{
			Id = id;
			_name = name;
			_text = text;
			_addTime = DateTime.Now;
		}


	}
}
