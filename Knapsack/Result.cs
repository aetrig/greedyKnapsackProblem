namespace Knapsack;

public class Result
{
	List<int> items = new();
	int value;
	public int weight;

	public Result() {
		value = 0;
		weight = 0;
	}

	public void AddItem(int id, int weight, int value) {
		items.Add(id);
		this.value += value;
		this.weight += weight;
	}

	public override string ToString()
	{
		string output = "items:";
		foreach (int item in items) {
			output += $" {item}";
		}
		
		output += $"\ntotal value: {value}";
		output += $"\ntotal weight: {weight}";

		return output;
	}
}
