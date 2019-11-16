using GWTFramework;

namespace Scratch
{
    internal class Given : IAnd<Given>
    {
        internal Given()
        {
            And = this;
        }

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
