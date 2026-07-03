using LeetCode.Core.Problems.P0001_TwoSum;

namespace LeetCode.Tests.Problems;

public class P0001_TwoSumTests
{
    [Fact]
    public void ReturnsIndexesForSampleCase()
    {
        var solution = new Solution();

        int[] result = solution.TwoSum([2, 7, 11, 15], 9);

        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void ReturnsIndexesWhenPairAppearsLater()
    {
        var solution = new Solution();

        int[] result = solution.TwoSum([3, 2, 4], 6);

        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void ReturnsIndexesWhenValuesRepeat()
    {
        var solution = new Solution();

        int[] result = solution.TwoSum([3, 3], 6);

        Assert.Equal([0, 1], result);
    }
}
