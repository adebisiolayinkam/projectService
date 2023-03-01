using projectService_valueAPI.Models;
using System.Linq.Expressions;

namespace projectService_valueAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
