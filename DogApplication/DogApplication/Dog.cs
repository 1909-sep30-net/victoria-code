using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    internal class Dog
    {
        //access modifiers
        //public - everyone can see
        //internal - everyone in the same assembly (aka project) can see.
        //protected - everyone who is a subclass of Dog can see (even if it is in another project).
        //private - only this class can see
        //protected internal 
        //private protected 
        
        //for class members, private is default
        //for classes internal is default, only public and internal are even possible

        //constructor
        // -- if you don't write one, you get a default one like "Dog() {}" (zero param,zero extra behavior)

            public Dog(string name, int age)
        {
            this.name = name;
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.age = age;
        }

        //fields
        public string name;

        public int age;

    }
}
