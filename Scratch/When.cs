using GWTFramework;

namespace Scratch
{
    internal class When : IAnd<When>
    {
        public When()
        {
            And = this;
        }

        public When And { get; set; }

        public ApplicationCallStep<When> ICall()
        {
            return new DependentStepFactory<When>().Build<ApplicationCallStep<When>>();
        }

        public IAnd<When> DoNothingElse()
        {
            return this;
        }
    }
}
