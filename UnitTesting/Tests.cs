namespace UnitTesting;

public class Tests
{
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5, 6, 7}, 5, 4)]
    [InlineData(new []{8, 4, 0, 1, 5, 2, 6, 3}, 4, 1)]
    public void LinearSearch_Index(int[] A, int x, int expected)
    {
        Assert.Equal(expected, Algorithms.LinearSearch(A, x));
    }
    
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5, 6, 7}, 5, 4)]
    [InlineData(new []{8, 4, 0, 1, 5, 2, 6, 3}, 4, 1)]
    public void BetterLinearSearch_Index(int[] A, int x, int expected)
    {
        Assert.Equal(expected, Algorithms.BetterLinearSearch(A, x));
    }

    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5, 6, 7}, 5, 4)]
    [InlineData(new []{8, 4, 0, 1, 5, 2, 6, 3}, 4, 1)]
    public void LinearSearchWithSentinel_Index(int[] A, int x, int expected)
    {
        Assert.Equal(expected, Algorithms.LinearSearchWithSentinel(A, x));
    }

    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5, 6, 7}, 5, 4)]
    [InlineData(new []{8, 4, 0, 1, 5, 2, 6, 3}, 4, 1)]
    public void BinarySearch_Index(int[] A, int x, int expected)
    {
        Assert.Equal(expected, Algorithms.BinarySearch(A, x));
    }
    
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5, 6, 7}, 5, 4)]
    [InlineData(new []{8, 4, 0, 1, 5, 2, 6, 3}, 4, 1)]
    public void BinarySearchRecursive_Index(int[] A, int x, int expected)
    {
        Assert.Equal(expected, Algorithms.BinarySearchRecursive(A, 0, A.Length, x));
    }
}