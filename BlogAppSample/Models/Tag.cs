using System.ComponentModel.DataAnnotations;

namespace BlogAppSample.Models;

public class Tag
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "وارد کردن نام تگ اجباری است")]
    [MaxLength(100,ErrorMessage ="طول عنوان نباید بیشتر از 50 کاراکتر باشد")]
    public required string Name { get; set; }  

}
