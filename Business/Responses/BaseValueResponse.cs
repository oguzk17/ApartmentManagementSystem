using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses
{
    public class BaseValueResponse<T>
    {

        public BaseValueResponse(bool status)
        {
            Status = status;
        }

        public BaseValueResponse(bool status, T entity) : this(status)
        {

            Entity = entity;
        }
        public bool Status { get; set; }
        public T Entity { get; set; }
    }
}
