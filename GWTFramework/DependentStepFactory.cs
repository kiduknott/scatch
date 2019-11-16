using System;

namespace GWTFramework
{
    public class DependentStepFactory<T> : IAnd<T> //where T : new()
    {
        private T _caller;

        public DependentStepFactory(T caller)
        {
            _caller = caller;
        }

        public T And { get; set; }

        public T2 Build<T2>() where T2 : IAnd<T>, new()
        {
            return new T2 { And = _caller };
        }
    }
}
