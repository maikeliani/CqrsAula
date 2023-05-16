using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cqrs.Domain.Domain;

namespace Cqrs.Domain.Contracts
{
    public interface IPersonRepository
    {
        Task InsertAsync(Person person, CancellationToken cancellationToken);
    }
}
