using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Infrustructure.Data.EntityModels
{
    public class Address
    {
        public int Id { get; set; }
        public string House { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }

}
