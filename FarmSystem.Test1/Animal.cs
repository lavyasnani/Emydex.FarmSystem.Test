using System;

namespace FarmSystem.Test
{
    public class Animal 
    {
        public string name;

        public virtual void Talk() { }
        public virtual void Walk() { }
        public virtual void Run() { }
        public virtual void ProduceMilk() { }

    }
}