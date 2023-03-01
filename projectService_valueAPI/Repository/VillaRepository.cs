using Microsoft.EntityFrameworkCore;
using projectService_valueAPI.Data;
using projectService_valueAPI.Models;
using projectService_valueAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace projectService_valueAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
          
        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
