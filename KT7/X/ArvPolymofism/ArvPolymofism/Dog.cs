using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymofism
{
    class Dog : Animal , IEater
    {
        public string Name { get; protected set; }

        public Dog() : base(true)
        {
            this.Name = null;
        }

        public Dog(string Name) : base(true)
        {
            this.Name = Name;
        }

        public void EatFood()
        {
            IsHungry = false;
        }

        public string GetDogName()
        {
            return Name;
        }

        public Dog FromName(string Name)
        {
            return new Dog(Name);
        }
    
    }
}
