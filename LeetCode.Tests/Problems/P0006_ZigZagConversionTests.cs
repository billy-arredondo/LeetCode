using LeetCode.Core.Problems.P0006_ZigZagConversion;

namespace LeetCode.Tests.Problems;

public class P0006_ZigZagConversionTests
{
    [Theory]
    [InlineData("TIANAJAZMIN", 1, "TIANAJAZMIN")]
    [InlineData("TIANAJAZMIN", 2, "TAAAMNINJZI")]
    [InlineData("TIANAJAZMIN", 3, "TAMINJZIAAN")]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    public void ConvertsSampleCases(string input, int numRows, string expected)
    {
        var solution = new Solution();

        string result = solution.Convert(input, numRows);

        Assert.Equal(expected, result);
    }
}
