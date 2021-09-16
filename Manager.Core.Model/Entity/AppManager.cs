using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model.Entity
{
   public class AppManager:EntityBase
    {
        public string ManagerName { get; set; }
        public string ManagerLastName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public IEnumerable<Bank> Banks { get; set; }
    }
}
