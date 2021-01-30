using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public Janr Janr { get; set; }
        public int JanrId { get; set; }

    }
}
