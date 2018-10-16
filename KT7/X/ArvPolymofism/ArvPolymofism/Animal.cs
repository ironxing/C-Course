using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymofism
{
    class Animal
    {
        protected bool IsHungry { get; set; }

        public Animal(bool isHungry)
        {
            this.IsHungry = isHungry;
        }
    }
}
