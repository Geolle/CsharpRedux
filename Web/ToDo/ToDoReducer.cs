using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Redux
{
    public class ToDoReducer :Reducer 
    {

        public IEnumerable<string> Constants { get; set; }

        public override object InitState
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override IEnumerable<string> Constants
        {
            get
            {
                throw new NotImplementedException();
            }

            protected set
            {

            }
        }

        public void ChangeState(string type, object state);

        public override void ChangeState(string type, object state)
        {
            throw new NotImplementedException();
        }
    }
}