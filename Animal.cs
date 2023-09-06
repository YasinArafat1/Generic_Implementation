using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public class Animal
    {
        string name;
        int age;
        AnimalType type;
        Gender gender;

        public Animal(string Name,int Age,AnimalType Type,Gender Gender)
        {
            name = Name;
            age = Age;
            type = Type;
            gender = Gender;
            
        }

        public object this[int index]//this is indexer 
        {
            get
            {
                if (index == 1)
                    return name;
                else if (index == 2)
                    return age;
                else if (index == 3)
                    return type;
                else return gender;
            }
            set
            {

            }
        }



    }
}
