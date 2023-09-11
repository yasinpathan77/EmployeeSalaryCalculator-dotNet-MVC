using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using EmployeeSalary.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Namespace;
public class User : BaseEntity
{
    [Required]
    public string? Name { get; set; }

    public int PhoneNumber { get; set; }

    public string? Password { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DataType(DataType.Date)]
    [Required]
    public DateTime DateOfJoining { get; set; } = DateTime.Now;

    [ForeignKey("Address")]
    public int? AddressId { get; set; }

    public Address? Address { get; set; }
}
