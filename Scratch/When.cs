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
            return new DependentStepFactory<When>().Build<ApplicationCallStep<When>>();
        }

        public IAnd<When> DoNothingElse()
        {
            return this;
        }

        public T DependentStepFactory2<T>() where T : IAnd<When>, new()
        {
            return new T() { And = this.And };
        }
    }
}
