using System.ComponentModel.DataAnnotations;

namespace FureverHome.Enums
{
    public enum UserRoles
    {
        [Display(Name = "Adopter")]
        Adopter = 1,

        [Display(Name = "Shelter Admin")]
        ShelterAdmin = 2,

        [Display(Name = "Shelter Staff")]
        ShelterStaff = 3,

        [Display(Name = "Super Admin")]
        SuperAdmin = 4
    }
}
