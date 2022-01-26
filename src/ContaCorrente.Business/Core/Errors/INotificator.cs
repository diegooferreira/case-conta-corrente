using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Core.Errors
{
    public interface INotificator
    {
        bool HasErrors();
        List<Error> GetErrors();
        void Handle(Error error);
    }
}
