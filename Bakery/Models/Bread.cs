
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
      return 1;
    }

  }
}
