using MaquinaDeTroco.Domain.Models;
using MaquinaDeTroco.Infra.Data.Repository.Interfaces;
using MaquinaDeTroco.Services.Interfaces;

namespace MaquinaDeTroco.Services.Services
{
	public class UserService : IUserService
	{
		private readonly IUnitOfWork _unitOfWork;

		public UserService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public User GetById(Guid id) => _unitOfWork.User.GetById(id);

		public IEnumerable<User> GetAll() => _unitOfWork.User.GetAll();

		public void Add(User entity)
		{
			_unitOfWork.User.Add(entity);
			_unitOfWork.Save();
		}
		public void Update(User entity)
		{
			_unitOfWork.User.Update(entity);
			_unitOfWork.Save();
		}

		public void Remove(User entity)
		{
			_unitOfWork.User.Remove(entity);
			_unitOfWork.Save();
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
