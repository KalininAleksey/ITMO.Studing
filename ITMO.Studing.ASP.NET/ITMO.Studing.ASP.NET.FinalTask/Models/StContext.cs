using System.Data.Entity;

namespace ITMO.Studing.ASP.NET.FinalTask.Models
{
    public class StContext : DbContext
    {

            public DbSet<Student> Students { get; set; }
            public DbSet<StudentPerfomance> StudentsPerfomance { get; set; }

    }
}
