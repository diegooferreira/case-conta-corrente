using ContaCorrente.Business.Core.Data;
using ContaCorrente.Infra.EF.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Infra.EF.Data.Repository
{
    public class TransactionalScope : ITransactionalScope
    {
        protected readonly ApplicationDbContext Db;

        private IDbContextTransaction Transaction { get; set; }

        protected TransactionalScope(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task Complete()
        {
            await Transaction.CommitAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
            Transaction?.Dispose();
        }

        public async Task Open()
        {
            Transaction = await Db.Database.BeginTransactionAsync();
        }

        public async Task RevertChanges()
        {
            await Transaction.RollbackAsync();
        }
    }
}
