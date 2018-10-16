using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymofism
{
    class DogPound : List<Dog>
    {
        public List<Dog> GetDogsByName(string name)
        {
            List<Dog> aList = new List<Dog>();
            foreach (var item in this)
            {
                if(item.Name == name)
                {
                    aList.Add(item);
                }
            }
            return aList;
        }

        public void Feed()
        {
            foreach (var item in this)
            {
                item.EatFood();
            }
        }
    }
}
