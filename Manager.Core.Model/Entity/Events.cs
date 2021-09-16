using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Core.Model.Entity
{
   public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Select Date")]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Select Date")]
        public DateTime End { get; set; }
        public bool IsFullDay { get; set; }
        public bool IsPayment { get; set; }
        public int CitizenID { get; set; }
        public IEnumerable<Citizen> Citizens { get; set; }
    }
}
