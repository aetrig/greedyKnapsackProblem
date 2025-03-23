using Knapsack;

namespace Tests;

[TestClass]
public sealed class UnitTest
{
    [TestMethod]
    //Checks if number of generated elements is correct
    public void TestMethodCountElements()
    {
        List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
        foreach(int n in sizes) 
        {
            Problem problem = new Problem(n);
            Assert.AreEqual(n, problem.items.Count);
        }
    }

    [TestMethod]
    //Checks whether at least one item was put in the back if any item fits
    public void TestMethodAtLeastOne()
    {
        Random random = new Random();
        Problem problem = new Problem(random.Next(10)+1, random.Next());
        int capacity = random.Next(10)+1;
        Result result = problem.Solve(capacity);
        bool atLeastOne = false;
        foreach (Item item in problem.items)
        {
            if (item.weight <= capacity)
            {
                atLeastOne = true;
            }
        }
        if (atLeastOne)
        {
            Assert.IsFalse(result.weight == 0);
        }
    }

    [TestMethod]
    //Checks whether 0 items have been put in the backpack if none fit
    public void TestMethodNone()
    {
        Random random = new Random();
        Problem problem = new Problem(random.Next(10) + 1, random.Next());
        int capacity = random.Next(10) + 1;
        Result result = problem.Solve(capacity);
        bool zeroItems = true;
        foreach (Item item in problem.items)
        {
            if (item.weight <= capacity)
            {
                zeroItems = false;
            }
        }
        if (zeroItems)
        {
            Assert.AreEqual(result.weight,0);
        }
    }

    [TestMethod]
    //Checks the specific instance of the problem (Seed=1, ItemCount=10, Capacity=10)
    public void TestMethodInstance()
    {
        Problem problem = new Problem(10,1);
        int capacity = 10;
        Result result = problem.Solve(capacity);
        List<int> knownSolution = new List<int>() {4, 5, 3, 8};
        Assert.IsTrue(knownSolution.SequenceEqual(result.items));
    }

    [TestMethod]
    //Checks if the number of items put in the backpack is at most the number of generated items
    public void TestMethodAtMostGeneratedItems()
    {
        Random random = new Random();
        int itemCount = random.Next(10)+1;
        Problem problem = new Problem(itemCount, random.Next());
        int capacity = random.Next(10) + 1;
        Result result = problem.Solve(capacity);
        Assert.IsTrue(result.items.Count <= itemCount);
    }

    [TestMethod]
    //Checks whether the numbers of items put in the backpack is not equal to its capacity if the number of generated items with weight 1 is less than capacity
    public void TestMethodNotAllItemsOne()
    {
        Random random = new Random();
        int itemCount = random.Next(10) + 1;
        Problem problem = new Problem(itemCount, random.Next());
        int capacity = random.Next(10) + 1;
        Result result = problem.Solve(capacity);
        int onesCount = 0;
        foreach (Item item in problem.items)
        {
            if (item.weight == 1)
            {
                onesCount++;
            }
        }
        if (onesCount < capacity)
        {
            Assert.AreNotEqual(capacity, result.items.Count);
        }
    }
}
