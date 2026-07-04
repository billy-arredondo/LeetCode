using LeetCode.Core.Problems.P0007_ReverseInteger;

namespace LeetCode.Tests.Problems;

public class P0007_ReverseIntegerTests
{
  [Theory]
  [InlineData(12345, 54321)]
  [InlineData(-12345, -54321)]
  [InlineData(120, 21)]
  [InlineData(1534236469, 0)]
  public void InvertNumbers(int input, long expected)
  {
    var solution = new Solution();

    var result = (long)solution.Reverse(input);

    Assert.Equal(expected, result);
  }
}
