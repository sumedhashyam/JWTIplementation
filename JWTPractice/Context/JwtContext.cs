using JWTPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTPractice.Context
{
    public class JwtContext: DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options): base(options) { 
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }

        
    }
}
