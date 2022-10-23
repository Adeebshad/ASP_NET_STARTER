using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Core.Models.RequestModels
{
    public class AddressRequestModel
    {
        [Required]
        public string House { get; set; }

        [Required]
        public string Road { get; set; }

        [Required]
        public string City { get; set; }
    }
}
