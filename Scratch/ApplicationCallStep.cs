using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class ApplicationCallStep<T> : IAnd<T>
    {
        public T And { get; set; }

        public IAnd<T> ExecuteTheApplication()
        {
            return this;
        }
    }
}
