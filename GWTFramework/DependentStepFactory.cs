using System;

namespace GWTFramework
{
    public class DependentStepFactory<T> : IAnd<T> where T : new()
    {
        public T And { get; set; }

        public T2 Build<T2>() where T2 : IAnd<T>, new()
        {
            var stepRoot = new T(); //Hack - not the original Given, When, Then instance
            return new T2 { And = stepRoot };
        }
    }
}
