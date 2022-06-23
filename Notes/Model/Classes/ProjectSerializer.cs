using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Notes.Model.Classes
{
	class ProjectSerializer
	{
		/// <summary>
		/// Полный путь к файлу.
		/// </summary>
		public string Filename { get; set; }
		/// <summary>
		/// Инициализирует сериализацию.
		/// </summary>
		public void Init()
		{
			Properties.Settings.Default.DPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Nepsha/NoteApp/";
			Properties.Settings.Default.Save();
			Filename = Properties.Settings.Default.DPath;
			if (!Directory.Exists(Filename))
			{
				Directory.CreateDirectory(Filename);
			}
			Filename += "save.json";
		}
		/// <summary>
		/// Сохраняет в файл список экземпляров класса <see cref="Note"/>
		/// </summary>
		/// <param name="note">Экземпляр класса <see cref="Note"/></param>
		public void SaveToFile(List<Note> note)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(Filename))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, note);
			}
		}
		/// <summary>
		/// Загружает из файла список экземпляров класса <see cref="Note"/>
		/// </summary>
		/// <returns>Возращает список экземпляров класса <see cref="Note"/></returns>
		public List<Note> LoadFromFile()
		{
			var note = new List<Note>();
			if (File.Exists(Filename))
			{
				JsonSerializer serializer = new JsonSerializer();
				using (StreamReader sr = new StreamReader(Filename))
			    using (JsonReader reader = new JsonTextReader(sr))
				{
					var test = serializer.Deserialize<JArray>(reader);
					note = test.ToObject<List<Note>>();
				}
			}
			return note;
		}
	}
}
