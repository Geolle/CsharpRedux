using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Redux
{
    public abstract class State
    {

        public abstract string Key { get; }

        public abstract object Value { get; }

    }
}