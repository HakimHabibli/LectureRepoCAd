namespace OverloadTask;

internal class Program
{
	static void Main(string[] args)
	{
		int area;
		int r = 5;
		int result = Figure( r,out area);
		Console.WriteLine(result);
	}
	static void Figure( int r,out int area) 
	{
		int pi = 3;
		area = pi * r * 2;
	}
	static void Figure(int a,int b,out )
	{
		int area;
		area = (a * b)/2;
	}
}
