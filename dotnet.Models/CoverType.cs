using System.ComponentModel.DataAnnotations;

namespace dotnet.Models;

public class CoverType{
    [KeyAttribute]
    public int Id { get; set; }
    [Required]
    [Display(Name="Cover Type")]
    public String Name { get; set; }

}

