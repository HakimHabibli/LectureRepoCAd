namespace June4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int area;
			int r = 5;
			Figure(r, out area);

			Console.WriteLine(area);
			Figure(4,5, out area);
			Console.WriteLine(area);

		}
		static void Figure(int r, out int area)
		{
			int pi = 3;
			area = (pi*r)+ (pi* r);
		}
		static void Figure(int a, int b, out int area )
		{
			area = (a * b) / 2;
		}
	}
}
