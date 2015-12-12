using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Lioness.DLA
{
    public class LionessdbContext:DbContext
    {
        public DbSet<Quotes> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = ApplicationData.Current.LocalFolder.Path + "\\Lioness.db";
            optionsBuilder.UseSqlite("Filename=" + dbPath);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
