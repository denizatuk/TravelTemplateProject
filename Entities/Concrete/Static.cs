using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Static
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Guide { get; set; }
        public string Customers { get; set; }
        public string Awards { get; set; }
        public bool Status { get; set; }
    }
}
