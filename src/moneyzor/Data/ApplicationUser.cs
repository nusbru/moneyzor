using Microsoft.AspNetCore.Identity;
using moneyzor.Entities;

namespace moneyzor.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<Account> Accounts { get; set; } = [];
}

