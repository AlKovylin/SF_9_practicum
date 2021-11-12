using System;
using System.Collections.Generic;
using System.Text;

namespace SF_9_practicum
{
    class CommandExeption : Exception
    {
        public CommandExeption(string message) 
            : base(message)
        { }
    }
}
