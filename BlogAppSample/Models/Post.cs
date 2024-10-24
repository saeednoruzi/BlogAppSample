using System.ComponentModel.DataAnnotations;

namespace BlogAppSample.Models;

public class Post
{
    public Guid Id{ get; set; }
    [Required(ErrorMessage ="وارد کردن عنوان پست اجباری است")]
    public required string Title { get; set; }
    public string? Content { get; set; }
    public List<Tag>? Tags { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Post post &&
               Id.Equals(post.Id);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}
