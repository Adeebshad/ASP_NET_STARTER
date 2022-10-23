using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractice.Infrustructure.Data.EntityModels;
using TestPractice.Infrustructure.Data.Repositories.Interfaces;

namespace TestPractice.Infrustructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context): base(context)
        {

        }
    }
}
