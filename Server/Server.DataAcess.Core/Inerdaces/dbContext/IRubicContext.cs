using Microsoft.EntityFrameworkCore;
using Server.DataAcess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.DataAcess.Core.Inerdaces.dbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {

        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancelltionToken = default);

    }
}
