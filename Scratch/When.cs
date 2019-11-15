using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class When : IAnd<When>
    {
        public When And { get; set; }

        public void IExecuteTheApplication() { }

        public When ICall()
        {
            return this;
        }

        public IAnd<When> ExecuteTheApplication()
        {
            return this;
        }
    }
}
