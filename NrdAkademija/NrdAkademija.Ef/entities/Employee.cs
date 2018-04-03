using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NrdAkademija.Ef.entities
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeInventory = new HashSet<EmployeeInventory>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(160)]
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Workplace { get; set; }

        public ICollection<EmployeeInventory> EmployeeInventory { get; set; }
    }
}
