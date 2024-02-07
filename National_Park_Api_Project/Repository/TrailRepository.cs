using Microsoft.EntityFrameworkCore;
using National_Park_Api_Project.Data;
using National_Park_Api_Project.Models;
using National_Park_Api_Project.Repository.IRepository;

namespace National_Park_Api_Project.Repository
{
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _context;
        public TrailRepository(ApplicationDbContext context)
        {
           _context = context;
        }
        public bool CreateTrail(Trail trail)
        {
            _context.Trails.Add(trail);
            return Save();
        }

        public bool DeleteTrail(Trail trail)
        {
            _context.Trails.Remove(trail);
            return Save();
        }

        public Trail GetTrail(int trailId)
        {
            return _context.Trails.Include(t => t.NationalPark).FirstOrDefault(t => t.Id == trailId);
        }

        public ICollection<Trail> GetTrails()
        {
            return _context.Trails.Include(t => t.NationalPark).ToList();
        }

        public ICollection<Trail> GetTrailsInNationalPark(int nationalParkId)
        {
            return _context.Trails.Include(t=>t.NationalPark)
                .Where(t=>t.NationalParkId == nationalParkId).ToList();
        }

        public bool Save()
        {
            return _context.SaveChanges()==1 ? true : false;
        }

        public bool TrailExists(int trailId)
        {
            return _context.Trails.Any(t=>t.Id==trailId);
        }

        public bool TrailExists(string trailName)
        {
            return _context.Trails.Any(t => t.Name==trailName);
        }

        public bool UpdateTrail(Trail trail)
        {
            _context.Trails.Update(trail);
            return Save();
        }
    }
}
