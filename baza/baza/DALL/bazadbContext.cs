using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace baza.DALL
{
    public class bazadbContext: DbContext
    {
        public DbSet<Participants> Participant { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = ApplicationData.Current.LocalFolder.Path + "\\bazaPodatakaTest.db";
            optionsBuilder.UseSqlite("Filename=" + dbPath);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
