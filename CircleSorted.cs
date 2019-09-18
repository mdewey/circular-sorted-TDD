using System.Linq;

namespace testing
{
  public static class CircleSorted
  {
    public static bool IsCircleSorted(int[] arr)
    {
      var things = arr
        .Select((current, index) => new { current, next = arr[(index + 1) % arr.Count()] });
      var count = things.Count(a => a.current > a.next);
      return count <= 1;

    }
  }
}
