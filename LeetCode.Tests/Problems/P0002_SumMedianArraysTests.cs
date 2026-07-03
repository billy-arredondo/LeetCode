using LeetCode.Core.Problems.P0002_SumMedianArrays;

namespace LeetCode.Tests.Problems;

public class P0002_SumMedianArraysTests
{
    [Fact]
    public void ReturnsMedianForOddLength()
    {
        var solution = new Solution();

        double result = solution.FindMedianSortedArrays([1, 3], [2]);

        Assert.Equal(2, result);
    }

    [Fact]
    public void ReturnsMedianForEvenLength()
    {
        var solution = new Solution();

        double result = solution.FindMedianSortedArrays([1, 2], [3, 4]);

        Assert.Equal(2.5, result);
    }

    [Fact]
    public void ReturnsMedianWhenOneArrayIsEmpty()
    {
        var solution = new Solution();

        double result = solution.FindMedianSortedArrays([], [1]);

        Assert.Equal(1, result);
    }
}
