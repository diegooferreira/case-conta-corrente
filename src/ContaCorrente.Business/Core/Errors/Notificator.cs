using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.Business.Core.Errors
{
    public class Notificator : INotificator
    {
        private List<Error> _errors;

        public Notificator()
        {
            _errors = new List<Error>();
        }

        public List<Error> GetErrors()
        {
            return _errors;
        }

        public void Handle(Error error)
        {
            _errors.Add(error);
        }

        public bool HasErrors()
        {
            return _errors.Any();
        }
    }
}
