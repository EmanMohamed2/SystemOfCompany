using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Model
{
    public class Company
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; } 

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        
        public virtual ICollection<DepartmentOfCompany> Departments { get; set; } = new HashSet<DepartmentOfCompany>();
    }
}