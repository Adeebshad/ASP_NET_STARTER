using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.RequestModels;
using TestPractice.Core.Models.ViewModels;
using TestPractice.Core.Services.Interfaces;
using TestPractice.Infrustructure.Data.EntityModels;
using TestPractice.Infrustructure.Data.Repositories.Interfaces;

namespace TestPractice.Core.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AddressViewModel>> GetAddresses()
        {
            IEnumerable<Address> addresses = await _repository.GetAsync();
            return _mapper.Map<IEnumerable<AddressViewModel>>(addresses);
        }

        public async Task SaveAddress(AddressRequestModel requestModel)
        {
            var address = _mapper.Map<Address>(requestModel);
            await _repository.InsertAsync(address);
            await _repository.CommitAsync();
        }
    }
}
