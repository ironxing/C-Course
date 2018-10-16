using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPolymofism
{
    class AnimalColletion<T>: List<T> where T : IEater, INameable {
        public List<INameable> GetAnimalsByName (string name)
        {
            List<INameable> aList = new List<INameable>();
            foreach (var element in this)
            {
                if (element.Name == name)
                {
                    aList.Add(element);
                }
            }
            return aList;
        }
    }
}
