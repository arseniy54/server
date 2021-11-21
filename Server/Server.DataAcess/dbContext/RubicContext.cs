using Microsoft.EntityFrameworkCore;
using Server.DataAcess.Core.Inerdaces.dbContext;
using Server.DataAcess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Server.DataAcess.dbContext
{
    public class RubicContext : DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }

        public Task<int> SaveChangeAsync(CancellationToken cancelltionToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
