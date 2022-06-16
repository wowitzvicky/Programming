using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Notes.Model.Classes
{
	class ProjectSerializer
	{
		public string Filename { get; set; }

		public void SaveToFile(List<Note> note)
		{


			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(Filename))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				
				serializer.Serialize(writer, note);
			}


		}
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
