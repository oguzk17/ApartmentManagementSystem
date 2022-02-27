using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key.GetType().Name}) was not found.")
        {

        }
        public NotFoundException(object key)
            : base($"Entity \"{key.GetType().Name.ToString()}\"  was not found.")
        {
        }

        public NotFoundException(string name)
            : base($"Entity \"{name}\"  was not found.")
        {
        }
    }
}
