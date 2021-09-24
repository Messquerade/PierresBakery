
namespace Bakery.Models
{
  public class Pastry
  {
    public int TotalPastries { get; set; }
    
    public Pastry(int numberOfPastries)
    {
      TotalPastries = numberOfPastries;
    }

    public int GetPastryCost()
    {
      return 1;
    }
  }
}