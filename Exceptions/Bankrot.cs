using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Bankrot:Exception
    {
        public Bankrot(string message):base(message) // Наше скл. будет получать строку и выводить её
        { }
    }
}
