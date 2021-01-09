using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthServerJWT.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();

    }
}
