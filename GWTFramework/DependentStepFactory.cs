using System;

namespace GWTFramework
{
    public class DependentStepFactory<T> : IAnd<T>
    {
        public T And { get; set; }

        public T2 Build<T2>() where T2 : IAnd<T>, new()
        {
            return new T2() { And = this.And };
        }
    }
}
