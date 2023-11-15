namespace Day3
{
	 class Program
	{
		static void Main()
		{
			int y = 10;
			y = +1;
			String result = (y % 2 == 0) ? "y is even" : "y is odd";
			Console.WriteLine(result);

			int x = 970;
			x -= 1;

			String result1 = (x % 3 == 0) ? "x is divisable to 3" : " x is not divisable to3";
			Console.WriteLine($"the result is {result1}");
		}
	}
}