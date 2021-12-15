using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Plaksina
{
	public class AerodromCollection
	{
		readonly Dictionary<string, Aerodrom<Vehicle>> aerodromStages;
		public List<string> Keys => aerodromStages.Keys.ToList();

		private readonly int pictureWidth;

		private readonly int pictureHeight;

		private readonly char separator = ':';
		public AerodromCollection(int pictureWidth, int pictureHeight)
		{
			aerodromStages = new Dictionary<string, Aerodrom<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddAerodrom(string name)
		{
			if (aerodromStages.ContainsKey(name))
			{
				return;
			}
			aerodromStages.Add(name, new Aerodrom<Vehicle>(pictureWidth, pictureHeight));
		}

		public void DelAerodrom(string name)
		{
			if (aerodromStages.ContainsKey(name))
			{
				aerodromStages.Remove(name);
			}
		}

		public Aerodrom<Vehicle> this[string ind]
		{
			get
			{
				if (aerodromStages.ContainsKey(ind))
				{
					return aerodromStages[ind];
				}
				else
				{
					return null;
				}
			}
		}
		public void SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine($"AerodromCollection");
				foreach (var level in aerodromStages)
				{
					sw.WriteLine($"Aerodrom{separator}{level.Key}");
					foreach (ITransport aer in level.Value)
					{
						if (aer.GetType().Name == "Airplane")
						{
							sw.Write($"Airplane{separator}");
						}
						if (aer.GetType().Name == "Aerobus")
						{
							sw.Write($"Aerobus{separator}");
						}
						sw.WriteLine(aer);
					}
				}
			}
		}
		public void LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			using (StreamReader sr = new StreamReader(filename))
			{
				string line = sr.ReadLine();
				string key = string.Empty;
				Vehicle aer = null;
				if (line.Contains("AerodromCollection"))
				{
					aerodromStages.Clear();
				}
				else
				{
					throw new FileLoadException("Неверный формат файла");

				}
				line = sr.ReadLine();
				while (line != null)
				{
					if (line.Contains("AerodromStation"))
					{
						key = line.Split(separator)[1];
						aerodromStages.Add(key, new Aerodrom<Vehicle>(pictureWidth, pictureHeight));
						line = sr.ReadLine();
						continue;
					}
					if (string.IsNullOrEmpty(line))
					{
						line = sr.ReadLine();
						continue;
					}
					if (line.Split(separator)[0] == "Airplane")
					{
						aer = new Airplane(line.Split(separator)[1]);
					}
					else if (line.Split(separator)[0] == "Aerobus")
					{
						aer = new Aerobus(line.Split(separator)[1]);
					}
					var result = aerodromStages[key] + aer;
					if (!result)
					{
						throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
					}
					line = sr.ReadLine();
				}
			}
		}
	}
}
