using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Infrustructure.Data.EntityModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Address Address { get; set; }
    }
}
