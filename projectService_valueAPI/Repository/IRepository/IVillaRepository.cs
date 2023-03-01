using projectService_valueAPI.Models;
using System.Linq.Expressions;

namespace projectService_valueAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
     
        Task<Villa> UpdateAsync(Villa entity);

    }
}
