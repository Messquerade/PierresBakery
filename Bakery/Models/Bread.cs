
namespace Bakery.Models
{
  public class Bread
  {
    public int TotalLoaves { get; set; }
    
    public Bread(int numberOfLoaves)
    {
      TotalLoaves = numberOfLoaves;
    }

    public int GetBreadCost()
    {
      int factor = TotalLoaves / 3;
      int result = (TotalLoaves * 5) - (factor * 5);
      return result;
    }

  }
}
