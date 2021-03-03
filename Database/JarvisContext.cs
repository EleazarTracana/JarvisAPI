using Microsoft.EntityFrameworkCore;
using NetJarvisAPI.Models;
using System.Collections.Generic;

namespace NetJarvisAPI.Database 
{
    public class JarvisContext : DbContext  {
        
        public DbSet<RecognizedHuman>  RecognizedHumans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer("Server=(localdb)\\Jarvis;Database=Jarvis;Trusted_Connection=True;");
    }
}