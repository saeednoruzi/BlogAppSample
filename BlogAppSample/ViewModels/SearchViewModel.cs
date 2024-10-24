using BlogAppSample.Models;

namespace BlogAppSample.ViewModels;

public class SearchViewModel
{
    public string? TagName { get; set; }
    public List<Post>? Posts{ get; set; }
}
