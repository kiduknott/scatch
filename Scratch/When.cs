using System;
using System.Collections.Generic;
using System.Text;

namespace Scratch
{
    internal class When : IAnd<When>
    {
        public When And { get; set; }

        public ApplicationCallStep<When> ICall()
        {
            return DependentStepFactory<ApplicationCallStep<When>>();
        }

        public IAnd<When> DoNothingElse()
        {
            return this;
        }

        public T DependentStepFactory<T>() where T : IAnd<When>, new()
        {
            return new T() { And = this.And };
        }
    }
}
