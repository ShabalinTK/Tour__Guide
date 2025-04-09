using System.ComponentModel.DataAnnotations;

namespace Tour_Guide_Api.Models.Entities;

public class Tour
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Theme { get; set; }
    public int Reviews { get; set; }
    public string ImageUrls { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public List<string> Activities { get; set; }
    public Dictionary<string, List<string>> Includes { get; set; } = new Dictionary<string, List<string>>()
    {
        ["Includes"] = new List<string>(),
        ["NotIncludes"] = new List<string>()
    };
    public List<string> Safety { get; set; }
    public Dictionary<string, object> Details { get; set; } = new Dictionary<string, object>()
    {
        ["Language"] = new List<string>(),
        ["Duration"] = "",
        ["NumberOfPeople"] = ""
    };
    public string Address { get; set; }
}
