using Microsoft.AspNetCore.Authorization;

namespace KhumaloCrafts.Models
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardModel
    {
  
        public void OnGet()
        {
            // Add any necessary logic here
        }
    }
}
