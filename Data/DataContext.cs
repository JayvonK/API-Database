using API_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Database.Data;

    public class DataContext : DbContext
    {
        // This sets up database functionality on the class
        // DbContextOptions<DataContext> is a EF Core class that allows us to access database configuration settings like the connection string
        // the base keyword is allowing use to access stuff from the base or parent class
        public DataContext(DbContextOptions<DataContext> options) : base(options)  
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
