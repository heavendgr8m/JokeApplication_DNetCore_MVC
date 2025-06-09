using System.ComponentModel.DataAnnotations;

public class ApplicationUser
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; }
}
