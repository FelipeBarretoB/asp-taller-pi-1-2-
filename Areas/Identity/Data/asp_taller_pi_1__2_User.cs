using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_taller_pi_1__2_.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the asp_taller_pi_1__2_User class
    public class asp_taller_pi_1__2_User : IdentityUser
    {
        public string UserNamed { get; set; }
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string firstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
