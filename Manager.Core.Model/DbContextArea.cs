using Manager.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model
{
   public class DbContextArea: DbContext
    {
        public DbContextArea()
            : base(@"Data Source=DESKTOP-SA9DESS;Initial Catalog=ApartmentManagerDB;Integrated Security=True")
        {
        }
        
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<AppManager> AppManagers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Events> Events { get; set; }

    }
}
