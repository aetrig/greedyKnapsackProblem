
namespace Knapsack;
class Program
{
    static void Main(string[] args)
    {
		Console.WriteLine("Enter seed:");
		int seed = int.Parse(Console.ReadLine() ?? "0");
		Console.WriteLine("Enter number of items:");
		int itemCount = int.Parse(Console.ReadLine() ?? "0");
		Problem p1 = new(itemCount, seed);
		Console.WriteLine(p1);

		Console.WriteLine("Enter capacity:");
		int capacity = int.Parse(Console.ReadLine() ?? "0");
		Result result = p1.Solve(capacity);
		Console.WriteLine(result);
	}
}
