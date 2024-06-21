using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class SQLSERVERContext : IdentityDbContext<ApplicationUser>
    {
        public SQLSERVERContext(DbContextOptions<SQLSERVERContext> options) : base(options) { }
    }
}
