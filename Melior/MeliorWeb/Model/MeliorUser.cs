using Microsoft.AspNetCore.Identity;

namespace MeliorWeb.Model
{
    public class MeliorUser : IdentityUser
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }
        public int Streak { get; set; }
    }
}
