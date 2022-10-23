using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Core.Models.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public string House { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
