public class Bach
{
  private string region = "";
  private string city = "";
  private string suburb = "";
  public string nearestBeach = "";
  public bool rentalAvailable = false;

  public Bach(string r, string c, string s, string n, bool re)
  {
    region = r;
    city = c;
    suburb = s;
    nearestBeach = n;
    rentalAvailable = re;
  }

  public bool compareBach(Bach b1)
  {
    if(this.region == b1.region && this.city == b1.city && this.suburb == b1.suburb && this.nearestBeach == b1.nearestBeach && this.rentalAvailable == b1.rentalAvailable)
    {
      return true;
    } 
    else 
    {
      return false;
    }
  }
}