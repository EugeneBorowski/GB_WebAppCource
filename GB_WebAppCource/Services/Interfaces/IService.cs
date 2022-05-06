using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;


namespace GB_WebAppCource.Services.Interfaces
{
    public interface IService<T> where T:class
    {
        Task<T> Get(int id);
        Task<T> Get(string id);
        Task<IList<T>> Get(int from, int to);
        Task<IList<T>> GetAll();
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);

    }
}
