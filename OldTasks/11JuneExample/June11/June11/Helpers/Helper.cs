using June11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace June11.Helpers
{
	public static class Helper
	{
		public static T Load<T>(T entity)
		where T : IEmployee,new()
		{
			foreach (PropertyInfo property in entity.GetType().GetProperties()) 
			{
				if (property.Name == "Id") { continue; }
				Console.Write($"Pls enter {property.Name} :");
				string value =Console.ReadLine();
				try
				{
					object convertedValue = Convert.ChangeType(value, property.PropertyType);
					property.SetValue(entity, convertedValue);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Gercersiz deger girdiniz . Hata{ex.Message}");
					return Load(entity);

				}

			}
			return default;
		}
		public static T WriteToConsole<T>(this T entity) 
		{
			foreach (PropertyInfo property in entity.GetType().GetProperties())
			{
			 Console.WriteLine($"{property.Name} : {property.GetValue(entity)}");
			}
			return default;
		}
	}
}
