namespace KatasCSharp;

public class IntegerArraySorterTest
{
    private readonly IntegerArraySorter _sorter = new();

    [TestCase(new int[] { 1, 3, 2, 8, 5, 4 }, new int[] { 5, 3, 2, 8, 1, 4 })]
    [TestCase(new int[] { 1, 3, 5, 8, 0 }, new int[] { 5, 3, 1, 8, 0 })]
    [TestCase(new int[] {}, new int[] {})]
    public void BaseTest(int[] expected, int[] inputArray)
    {
        var actual = _sorter.SortArray(inputArray);
        Assert.That(expected, Is.EqualTo(actual));
    }
}