using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Exceptions
{
    public class DuplicatedException : Exception
    {
        public DuplicatedException() : base("User Duplicated")
        {
        }

    }
}
