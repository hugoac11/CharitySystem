using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CharitySystem.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="char(100)")] // Sets the datatype as char with 100 max characters
        public string FirstName { get; set; }


        [PersonalData]
        [Column(TypeName = "char(100)")] // Sets the datatype as char with 100 max characters
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "char(100)")] // Sets the datatype as char with 100 max characters
        public string EMail { get; set; }

        [PersonalData]
        [Column(TypeName = "num(12)")] // Sets the datatype as number with 12 max characters
        public string PhoneNum { get; set; }

        [PersonalData]
        [Column(TypeName = "char(100)")] // Sets the datatype as char with 100 max characters
        public string Address { get; set; }

        [PersonalData]
        [Column(TypeName = "char(6)")] // Sets the datatype as char with 6 max characters for YY/MM/DD
        public string DOB { get; set; }

    }
}
