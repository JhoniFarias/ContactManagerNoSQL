using ContactManager.Domain.UserContext.Entities;
using ContactManager.Domain.UserContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {

        public Task Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Find()
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
