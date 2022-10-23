using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.ResponseModels;

namespace TestPractice.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task SaveUser(UserRequestModel requestModel);
        Task<IEnumerable<UserViewModel>> GetUsers();
    }
}
