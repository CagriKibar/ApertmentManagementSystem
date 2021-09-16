using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model.Entity
{
    public class Status:EntityBase
    {
        public int BankID { get; set; }
        public  Bank Bank { get; set; }
        public decimal TotalPrice { get; set; }

       
    }
}
