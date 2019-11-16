using GWTFramework;

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
