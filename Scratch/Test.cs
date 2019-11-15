using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace Scratch
{
    public class Test
    {
        internal static Given Given => new Given();
        internal static When When => new When();
        internal static Then Then => new Then();

        [Test]
        public void ScratchTest()
        {
            Given.IHaveSetUpTheInitialConditions().And.TheApplicationIsReadyToRun();
            When.ICall().ExecuteTheApplication().And.DoNothingElse();
            Then.TheApplicationBehavedAsExpected().And.TheApplicationShutDownGracefully();
        }
    }
}
