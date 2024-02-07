using National_Park_Api_Project.Models;

namespace National_Park_Api_Project.Repository.IRepository
{
    public interface ITrailRepository
    {
        ICollection<Trail> GetTrails(); //Display9
        Trail GetTrail(int trailId); //Find
        ICollection<Trail> GetTrailsInNationalPark(int nationalParkId);
        bool TrailExists(int trailId);
        bool TrailExists(string trailName);
        bool CreateTrail(Trail trail);
        bool UpdateTrail(Trail trail);
        bool DeleteTrail(Trail trail);
        bool Save();
    }
}
