using ContactManager.Domain.UserContext.Entities;

namespace ContactManager.Domain.UserContext.Repositories
{
    public interface IUserRepository
    {
        Task Add(User user);

        Task Update(User user);

        Task Delete(User user);

        Task<IEnumerable<User>> Find();
    }
}
