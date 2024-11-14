using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Domain.UserContext.Entities
{
    public class User
    {
        public User(string name, string cpf, string email)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Cpf { get; private set; }

        public string Email { get; private set; }

    }
}
