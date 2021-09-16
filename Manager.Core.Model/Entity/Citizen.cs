using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model.Entity
{
  public  class Citizen:EntityBase
    {
        public string CitizenName { get; set; }
        public string CitizenLastName { get; set; }
        public string Number { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Payment { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsManager { get; set; }
        public int EventID { get; set; }
        public IEnumerable<Bank> Banks { get; set; }
    }
}
