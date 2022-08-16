using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanySystem.Model
{
    public class DepartmentOfCompany
    {
        [Key]
        [Column(Order = 1)]
        public int CompanyID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
    }
}
