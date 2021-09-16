using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model.Entity
{
   public class Bank:EntityBase
    {
        public int CitizenID { get; set; }
        public Citizen Citizen { get; set; }
        public int ManagerID { get; set; }
        public AppManager Manager { get; set; }
        public DateTime? Date { get; set; }
        public string Expenses { get; set; }
        
    }
}
