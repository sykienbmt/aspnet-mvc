using System.ComponentModel.DataAnnotations;

namespace dotnet.Models;

public class Category{
    [KeyAttribute]
    public int Id { get; set; }
    [Required]
    public String Name { get; set; }
    public int DisplayOrder { get; set; }
            [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100")]

    public DateTime CreatedDateTime { get; set; }
}

