using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.RequestModels;
using TestPractice.Core.Models.ViewModels;
using TestPractice.Infrustructure.Data.EntityModels;

namespace TestPractice.Core.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressRequestModel, Address>();
            CreateMap<Address, AddressViewModel>();
        }
    }
}
