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
		public static int _allNotesCount=0;

		/// <summary>
		/// Уникальный Id - номер заметки.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Название заметки.
		/// </summary>
		public string _name { get; set; }

		/// <summary>
		/// Текст заметки.
		/// </summary>
		public string _text { get; set; }

		/// <summary>
		/// Категория заметки.
		/// </summary>
		public string _category { get; set; }
		
		/// <summary>
		/// Дата создания заметки.
		/// </summary>
		readonly public DateTime  _addTime;

		/// <summary>
		/// Возвращает либо увеличивает кол-во уже созданных заметок.
		/// </summary>
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

		/// <summary>
		/// Возвращает или задает название заметки.
		/// </summary>
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

		/// <summary>
		/// Возвращает или задает текст заметки.
		/// </summary>
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

		/// <summary>
		/// Возвращает или задает категорию заметки.
		/// </summary>
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

		/// <summary>
		/// Создает пустой экземпляр класса <see cref="Note"/>
		/// </summary>
		public Note()
		{

		}

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
			_name = name;
			_text = text;
			_category = category;
			_addTime = DateTime.Now;
		}
		/// <summary>
		/// Создает экземпляр класса <see cref="Note"/>
		/// </summary>
		/// <param name="id">Уникальный номер.</param>
		/// <param name="name">Название. Должно быть меньше 100 символов.</param>
		/// <param name="text">Текст.</param>
		public Note(int id,string name, string text)
		{
			Id = id;
			_name = name;
			_text = text;
			_addTime = DateTime.Now;
		}


	}
}
