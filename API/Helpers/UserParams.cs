namespace API.Helpers;

public class UserParams : PaginationParams
{
  
    public string CurrentUsername { get; set; }
    public string Genre { get; set; }
    public int MinAge { get; set; } = 1;
    public int MaxAge { get; set; } = 15;
    public string OrderBy { get; set; } = "lastActive";

}
