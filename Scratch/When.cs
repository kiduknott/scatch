using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class When : IAnd<When>
    {
        public When And { get; set; }

        public ApplicationCallStep ICall()
        {
            return new ApplicationCallStep();
        }
    }
}
