using ContactManager.Domain.UserContext.Entities;
using ContactManager.Domain.UserContext.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserRepository(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("contactManagerDb");
            var collection = database.GetCollection<User>("users");

            _usersCollection = collection;
        }

   

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
