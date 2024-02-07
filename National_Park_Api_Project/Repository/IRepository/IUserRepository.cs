using National_Park_Api_Project.Models;

namespace National_Park_Api_Project.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string userName);
        User Authenticate(string userName, string password);
        User Register(string userName, string password);

    }
}
