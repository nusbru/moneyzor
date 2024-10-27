using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using moneyzor.Entities;

namespace moneyzor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

    public DbSet<moneyzor.Entities.Account> Account { get; set; } = default!;

    public DbSet<moneyzor.Entities.TransactionCategory> TransactionCategory { get; set; } = default!;

    public DbSet<moneyzor.Entities.Transaction> Transaction { get; set; } = default!;
}
