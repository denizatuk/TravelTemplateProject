using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string CoverImage { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string DayOrNight { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
