
namespace LostAndFound.Web.Models;

public class LostItem
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public string Location { get; set; } = "";

    public string Status { get; set; } = "Lost";

    public DateTime DateReported { get; set; }
        = DateTime.Now;
}
