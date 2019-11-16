using GWTFramework;

namespace Scratch
{
    internal class Then : IAnd<Then>
    {
        internal Then()
        {
            And = this;
        }

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
