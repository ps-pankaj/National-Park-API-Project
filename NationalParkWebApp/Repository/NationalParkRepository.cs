using NationalParkWebApp.Models;
using NationalParkWebApp.Repository.IRepository;

namespace NationalParkWebApp.Repository
{
    public class NationalParkRepository:Repository<NationalPark>,INationalParkRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public NationalParkRepository(IHttpClientFactory httpClientFactory):base(httpClientFactory)
        {
              _httpClientFactory = httpClientFactory;
        }
    }
}
