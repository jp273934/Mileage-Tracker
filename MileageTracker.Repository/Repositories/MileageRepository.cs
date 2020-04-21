using MileageTracker.Repository.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MileageTracker.Repository.Repositories
{
    public class MileageRepository
    {
        private readonly MileageDbContext _dbContext;

        public MileageRepository()
        {
            _dbContext = new MileageDbContext();
        }

        public IEnumerable<Mileage> GetAllMileages()
        {
            return _dbContext.Mileage.ToList();
        }

        public void AddMileageRecord(Mileage mileage)
        {
            _dbContext.Mileage.Add(mileage);
            _dbContext.SaveChanges();
        }
    }
}
