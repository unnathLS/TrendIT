using apiAspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace apiAspNetCore.Data

{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : Base(options)
        { }

        public DbSet<Pessoa> pessoa { get; set; }




    }
}
