using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.ViewModels;

namespace TestPractice.Core.Models.ResponseModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public AddressViewModel Address { get; set; }
    }
}
