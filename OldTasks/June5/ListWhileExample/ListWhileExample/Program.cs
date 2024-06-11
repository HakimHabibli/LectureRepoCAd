using System.Threading.Tasks;

namespace ListWhileExample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine( ExampleWhileCount());
		}
		#region ListWhileTask





		#endregion
		#region ExampleWhileCount

		/// <summary>
		/// Arrayin nece dene oldugunu ve uzunlugunun nece dene oldugunu qedy edirik ve o bize daxil etdiyimiz array 
		/// sayi qeder indexleri bir birinden ferqli arraylar teqdim edir  
		/// </summary>
		public static List<int[]> ExampleWhileCount()
		{
			Console.WriteLine("Arrayin nece adet oldugunu kayd edin");
			int count = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Arrayin uzunlugunu kayd edin");
			int countLength = Convert.ToInt32(Console.ReadLine());

			List<int[]> list = new();

			while (count > 0)
			{
				list.Add(ExampleWhile(countLength));
				count--;

			}
			int i=0;
			int j = 0;
			while (i < list.Count) 
			{
				while (j < list[i].Length) 
				{
					Console.Write($"{list[i][j]} - ");
					j++;
				}
				i++;
			}
			

		}
		#endregion


		#region ExampleWhile

		/// <summary>
		/// Bir array ucun nezerde tutulmus random funksiyasi ile bir birine beraber olmayan indexlere sahib array verir 
		/// </summary>
		/// <param name="count">Arrayin uzunlugudur o uzunluqda array verir bize </param>
		public static int[] ExampleWhile(int count)
		{
			//Console.WriteLine("Arrayin uzunlugu ucun 1 ile 6 arasinda reqem daxil edin");
			//int count = Convert.ToInt32(Console.ReadLine());
			//if (count >= 1 && count <= 6)
			//{
				int[] array = new int[0];
				int random = Random.Shared.Next(1, 50);
				while (count != 0)
				{
					array.Contains(random);
						random = Random.Shared.Next(1, 50);
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = random;
					count--;
				}
				return array;

			//}
			//else
			//{
			//	return ;

			//}

		}
		#endregion

	}
}
