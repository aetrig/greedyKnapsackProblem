using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Tests")]

namespace Knapsack;
internal class Problem
{
	private int itemCount;
	internal List<Item> items = new();

	public Problem(int n, int seed = 0) 
	{
		Random rand = new(seed);
		itemCount = n;
		for (int i = 0; i < itemCount; i++) 
		{
			items.Add(new(i, rand.Next(10)+1, rand.Next(10)+1));
		}
	}

	public override string ToString() 
	{
		string output = "";
		for (int i = 0; i < itemCount; i++) 
		{
			output += $"item {items[i].id}: weight: {items[i].weight} value: {items[i].value}\n";
		}
		return output;
	}

	private static int compareItems(Item x, Item y) 
	{
		double xRatio = (double)x.value / (double)x.weight;
		double yRatio = (double)y.value / (double)y.weight;

		if (xRatio < yRatio) return 1;
		if (xRatio > yRatio) return -1;

		return 0;
	}
	public Result Solve(int capacity) 
	{
		items.Sort(compareItems);
		Result result = new();
		for (int i = 0; i < itemCount; i++) 
		{
			if (result.weight + items[i].weight <= capacity) 
			{
				result.AddItem(items[i].id, items[i].weight, items[i].value);
			}
		}
		return result;
	}
}
