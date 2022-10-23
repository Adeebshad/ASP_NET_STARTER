using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Core.Models.ResponseModels
{
    public class UserRequestModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }
    }
}
