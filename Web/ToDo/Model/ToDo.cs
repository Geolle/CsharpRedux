using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Redux;

namespace ToDo
{
    public class ToDo : State
    {

        public bool IsDeleted { get; set; }

        public List<string> List { get; set; }



        public override string Key { get { return "ToDo"; } }

        public override object Value { get { return this; } }

    }
}