using MaquinaDeTroco.Domain.Models;

namespace MaquinaDeTroco.Services.Interfaces
{
	public interface IUserService : IDisposable
	{
		User GetById(Guid id);
		IEnumerable<User> GetAll();
		void Add(User entity);
		void Update(User entity);
		void Remove(User entity);
	}
}
