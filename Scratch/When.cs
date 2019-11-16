using GWTFramework;

namespace Scratch
{
    internal class When : IAnd<When>
    {
        internal When()
        {
            And = this;
        }

        public When And { get; set; }

        public ApplicationCallStep<When> ICall()
        {
            return new DependentStepFactory<When>(this).Build<ApplicationCallStep<When>>();
        }

        public IAnd<When> DoNothingElse()
        {
            return this;
        }
    }
}
