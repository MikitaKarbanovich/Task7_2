﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2.Exceptions
{
    public class NotANumberException : Exception
    {
        public NotANumberException(string message) : base(message)
        {

        }
    }
}
