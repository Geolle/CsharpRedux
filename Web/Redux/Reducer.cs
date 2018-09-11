using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Redux
{
    public  abstract class Reducer
    {
       protected Reducer()
        {

        }

        public abstract object InitState { get; set; }

        public abstract IEnumerable<string> Constants { get; protected set; }

        public abstract void ChangeState(string type, object state);

    }
}