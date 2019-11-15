using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class Then : IAnd<Then>
    {
        public Then And { get; set; }

        public IAnd<Then> TheApplicationBehavedAsExpected()
        {
            return this;
        }

        public IAnd<Then> TheApplicationShutDownGracefully()
        {
            return this;
        }
    }
}
