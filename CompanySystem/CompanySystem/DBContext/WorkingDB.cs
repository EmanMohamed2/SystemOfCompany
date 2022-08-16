using Microsoft.EntityFrameworkCore;
using CompanySystem.Model;

namespace CompanySystem.DBContext
{
    public class WorkingDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentOfCompany> DepartmentsOfCompany { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DepartmentOfCompany>(entity =>
            {
                entity.HasKey(e => new { e.CompanyID, e.DepartmentID })
                .HasName("PK_CompanyDepartment");

                entity.ToTable("DepartmentOfCompany");

            });
        }

    }
}