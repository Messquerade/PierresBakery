
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
      int factor = TotalPastries / 3;
      int result = (TotalPastries * 2) - factor;
      return result;
    }
  }
}