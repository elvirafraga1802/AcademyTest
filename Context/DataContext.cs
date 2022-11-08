using AcademyTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Repositories{
    public class DataContext:DbContext{
        public DataContext(DbContextOptions <DataContext> options): base(options){}

        public DbSet <User> Users => Set<User>();
        public DbSet <InventoryItem> Items => Set<InventoryItem>();

    }
}