﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class StudentNotFoundException:Exception
    {
        public StudentNotFoundException(string str):base(str) { }
    }
}
