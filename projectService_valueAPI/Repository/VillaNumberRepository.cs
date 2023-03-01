using Microsoft.EntityFrameworkCore;
using projectService_valueAPI.Data;
using projectService_valueAPI.Models;
using projectService_valueAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace projectService_valueAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
          
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
