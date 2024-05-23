using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class UnderageException:Exception
    {
        public UnderageException(string str) :base(str) { }
    }
}
