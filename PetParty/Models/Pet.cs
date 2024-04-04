#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;

public class Pet
{
    // [DataType(DataType.Date)]
    // public string? Name { get;set; } //this would allow the string to hold a null
    [Required(ErrorMessage = "PLz gib name")]
    public string Name { get;set; }
    [Display(Name="Pet Type")]
    [MinLength(3)]
    public string Species { get;set; }
    [Range(1,int.MaxValue)]
    public int? Age { get;set; }
    public bool Urbanized { get;set; }
}