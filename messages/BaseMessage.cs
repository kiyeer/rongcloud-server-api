using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace io.rong.messages
{
    public abstract class BaseMessage
    {
        public abstract string GetType();

        override
        public abstract string ToString();
    }
}
