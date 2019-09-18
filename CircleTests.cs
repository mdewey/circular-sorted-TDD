using Xunit;

namespace testing
{
  public class CircleTests
  {
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 5, 0, 1 })]
    [InlineData(new int[] { 4, 5, 6, 9, 1 })]
    [InlineData(new int[] { 10, 11, 6, 7, 9 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 5, 7, 43, 987, -9, 0 })]
    [InlineData(new int[] { 1, 2, 3, 4, 1 })]
    public void TrueCases(int[] arr)
    {
      Assert.True(CircleSorted.IsCircleSorted(arr));
    }
    [Theory]
    [InlineData(new int[] { 4, 1, 2, 5 })]
    [InlineData(new int[] { 8, 7, 6, 5, 4, 3 })]
    [InlineData(new int[] { 6, 7, 4, 8 })]
    [InlineData(new int[] { 7, 6, 5, 4, 3, 2, 1 })]
    public void FalseCases(int[] arr)
    {
      Assert.False(CircleSorted.IsCircleSorted(arr));
    }


  }
}