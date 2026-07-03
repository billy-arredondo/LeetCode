namespace LeetCode.Core.Problems.P0006_ZigZagConversion;

public class Solution
{
  public string Convert(string s, int numRows)
  {
    if (numRows == 1 || numRows >= s.Length)
      return s;

    var rows = new List<char>[numRows];
    for (int i = 0; i < numRows; i++)
      rows[i] = [];

    var fallingDirection = false;
    var currentListIndex = 0;
    var currentMatrixRow = 0;

    while (currentListIndex < s.Length)
    {
      rows[currentMatrixRow].Add(s[currentListIndex]);

      if ((currentMatrixRow == 0) || (currentMatrixRow == numRows - 1))
        fallingDirection = !fallingDirection;

      currentMatrixRow = fallingDirection
        ? currentMatrixRow + 1
        : currentMatrixRow - 1;
      currentListIndex++;
    }

    return string.Join("", rows.SelectMany(x => x));
  }
}