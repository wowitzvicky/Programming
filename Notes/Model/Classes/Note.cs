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
		public static int AllNotesCount=0;
		/// <summary>
		/// Уникальный Id - номер заметки.
		/// </summary>
		private int _id { get; set; }
		/// <summary>
		/// Название заметки.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Текст заметки.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Категория заметки.
		/// </summary>
		public string Category { get; set; }
		/// <summary>
		/// Дата создания заметки.
		/// </summary>
	    public DateTime  AddTime;
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
		public string NotesName
		{
			get
			{
				return Name;
			}
			private set
			{
				Validator.AssertValueInRange(Name);
				Name = value;
			}
		}
		/// <summary>
		/// Возвращает или задает текст заметки.
		/// </summary>
		public string NotesText
		{
			get
			{
				return Text;
			}
			private set
			{
				Text = value;
			}
		}
		/// <summary>
		/// Возвращает или задает категорию заметки.
		/// </summary>
		public string NotesCategory
		{
			get
			{
				return Category;
			}
			private set
			{
				Category = value;
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
			Name = name;
			Text = text;
			Category = category;
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
			Name = name;
			Text = text;
			Category = category;
			AddTime = DateTime.Now;
		}


	}
}
