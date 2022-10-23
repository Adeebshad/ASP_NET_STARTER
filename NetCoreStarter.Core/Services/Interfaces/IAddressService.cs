using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Core.Models.RequestModels;
using TestPractice.Core.Models.ViewModels;

namespace TestPractice.Core.Services.Interfaces
{
    public interface IAddressService
    {
        Task SaveAddress(AddressRequestModel requestModel);
        Task<IEnumerable<AddressViewModel>> GetAddresses();
    }
}
