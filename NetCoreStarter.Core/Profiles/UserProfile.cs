using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.ResponseModels;
using TestPractice.Core.Models.ViewModels;
using TestPractice.Infrustructure.Data.EntityModels;

namespace TestPractice.Core.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRequestModel, User>();
            CreateMap<User, UserViewModel>();
        }
    }
}
