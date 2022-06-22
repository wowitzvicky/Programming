using System;
using Notes.Model;
namespace Notes.Model.Classes
{
	/// <summary>
	/// Хранит данные о заметках.
	/// </summary>
	public class Note
	{
		/// <summary>
		/// Количество уже созданных когда-либо заметок.
		/// </summary>
		public static int AllNotesCount = 0;

		/// <summary>
		/// Уникальный Id - номер заметки.
		/// </summary>
		private int _id { get; set; }

		/// <summary>
		/// Название заметки.
		/// </summary>
		public string NoteName { get; set; }

		/// <summary>
		/// Текст заметки.
		/// </summary>
		public string NoteText { get; set; }

		/// <summary>
		/// Категория заметки.
		/// </summary>
		public string NoteCategory { get; set; }
		
		
		/// <summary>
		/// Дата создания заметки.
		/// </summary>
		readonly public DateTime  AddTime;

		/// <summary>
		/// Возвращает либо увеличивает кол-во уже созданных заметок.
	    // </summary>
		public static int NotesCount
		{
			get
			{
				return AllNotesCount;
			}
			private set
			{
				AllNotesCount = value;
			}
		}

		public int Id
		{
			get
			{
				return _id;
			}
			private set
			{
				_id = value;
			}
		}

		/// <summary>
		/// Возвращает или задает название заметки.
		/// </summary>
		public string Name
		{
			get
			{
				return NoteName;
			}
			private set
			{
				Validator.AssertValueInRange(NoteName);
				NoteName = value;
			}
		}

		/// <summary>
		/// Возвращает или задает текст заметки.
		/// </summary>
		public string Text
		{
			get
			{
				return NoteText;
			}
			private set
			{
				NoteText = value;
			}
		}

		/// <summary>
		/// Возвращает или задает категорию заметки.
		/// </summary>
		public string Category
		{
			get
			{
				return NoteCategory;
			}
			private set
			{
				NoteText = value;
			}
		}

		/// <summary>
		/// Создает пустой экземпляр класса <see cref="Note"/>
		/// </summary>
		public Note(){}

		/// <summary>
		/// Создает экземпляр класса <see cref="Note"/>
		/// </summary>
		/// <param name="name">Название. Должно быть меньше 100 символов.</param>
		/// <param name="text">Текст</param>
		/// <param name="category">Категория</param>
		public Note(string name, string text,string category)
		{
			AllNotesCount++;
			Id = AllNotesCount;
			NoteName = name;
			NoteText = text;
			NoteCategory = category;
			AddTime = DateTime.Now;
		}

		/// <summary>
		/// Создает экземпляр класса <see cref="Note"/>
		/// </summary>
		/// <param name="id">Уникальный номер.</param>
		/// <param name="name">Название. Должно быть меньше 100 символов.</param>
		/// <param name="text">Текст.</param>
		public Note(int id,string name, string text, string category)
		{
			Id = id;
			NoteName = name;
			NoteText = text;
			NoteCategory = category;
			AddTime = DateTime.Now;
		}


	}
}
