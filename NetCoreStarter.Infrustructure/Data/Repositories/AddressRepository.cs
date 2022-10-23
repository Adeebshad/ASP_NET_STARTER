using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Infrustructure.Data.EntityModels;
using TestPractice.Infrustructure.Data.Repositories.Interfaces;

namespace TestPractice.Infrustructure.Data.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext context): base(context)
        {

        }
    }
}
