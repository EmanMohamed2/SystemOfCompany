using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.Model
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter Employee name")]
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
       
        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey(name: "Company")]

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; } = null!;
        [ForeignKey(name: "Department")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}