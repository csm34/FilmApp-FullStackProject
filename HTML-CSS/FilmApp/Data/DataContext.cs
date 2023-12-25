using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){
            
        }
        public DbSet<Film> Films => Set<Film>();
        public DbSet<User> Users => Set<User>();
        
    }
}