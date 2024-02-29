using Microsoft.AspNetCore.Identity;

namespace ApiPelicula.Models
{
    public class AppUser : IdentityUser
    {
        //
        public string Name { get; set; }
        public string Email {  get; set; }
    }
}
