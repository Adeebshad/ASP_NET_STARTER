using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.ResponseModels;
using TestPractice.Core.Services.Interfaces;
using TestPractice.Infrustructure.Data.EntityModels;
using TestPractice.Infrustructure.Data.Repositories.Interfaces;

namespace TestPractice.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserViewModel>> GetUsers()
        {
            IEnumerable<User> users = await _repository.GetAsync(null, null, "Address");
            return _mapper.Map<IEnumerable<UserViewModel>>(users);
        }

        public async Task SaveUser(UserRequestModel requestModel)
        {
            var user = _mapper.Map<User>(requestModel);
            await _repository.InsertAsync(user);
            await _repository.CommitAsync();
        }
    }
}
