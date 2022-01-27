using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Core.Data
{
    public interface ITransactionalScope : IDisposable
    {
        Task Open();
        Task Complete();
        Task RevertChanges();
    }
}
