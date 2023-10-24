using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using EmployeeSalary.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Namespace;
public class User : BaseEntity
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public long PhoneNumber { get; set; }

    [Required, DataType(DataType.Password)]
    public string? Password { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DataType(DataType.Date)]
    [Required]
    public DateTime DateOfJoining { get; set; } = DateTime.Now;
}
