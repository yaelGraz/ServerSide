using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;

namespace Repository.Interfaces
{
    public interface IDataSource
    {
        DbSet<Person> Persons { get; set; }
        abstract Task<int>  SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
