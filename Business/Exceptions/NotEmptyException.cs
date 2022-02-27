using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class NotEmptyException : ApplicationException
    {
        public NotEmptyException(string name)
           : base($"Entity \"{name}\"  was not empyty...")
        {
        }
    }
}
