using System;
namespace TodoApp.Repositories.Interfaces
{
	public interface IReference <T> where T: class
	{
		int Insert(T obj);
		int Update(T obj);
		int Delete(int id);
		T GetById(int id);
		List<T> GetAll();
	}
}

