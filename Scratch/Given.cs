using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class Given : IAnd<Given>
    {
        public Given And { get; set; }

        public IAnd<Given> IHaveSetUpTheInitialConditions()
        {
            return this;
        }

        public IAnd<Given> TheApplicationIsReadyToRun()
        {
            return this;
        }
    }
}
