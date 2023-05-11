using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KullanıcıKayıtSistemı.Areas.Identity.Data;

// Add profile data for application users by adding properties to the KullanıcıKayıtSistemıUser class
public class KullanıcıKayıtSistemıUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; internal set; }
    
}

