using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiTenancy.Core.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}