using Microsoft.AspNetCore.Mvc.Rendering;

namespace NationalParkWebApp.Models.ViewModels
{
    public class TrailVM
    {
        public Trail Trail { get; set; }
        public IEnumerable<SelectListItem> nationalParkList { get; set; }
    }
}
