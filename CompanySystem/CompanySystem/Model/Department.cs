
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Model
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<DepartmentOfCompany> Companies { get; set; } = new HashSet<DepartmentOfCompany>();
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
