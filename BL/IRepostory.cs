using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BL
{
    internal interface IRepostory<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(); 
        T Get(Expression<Func<T, bool>> expression);
        T Find();
        int Add(T entity);
        int Update(T entity);
        int Remove(T entity);

        Task<T> GetByAsync();
        Task<IEnumerable<T>> GetAllByAsync();
    }
}
