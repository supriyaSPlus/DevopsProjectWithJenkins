using System.ComponentModel.DataAnnotations;

namespace UserManagementProject.Models;

public class User{
     public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Contact Number")]
    public string ContactNumber { get; set; }
}