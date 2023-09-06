using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public class GenericBehaviour<T> : IGenericBehaviour<T>
    {
        public string GetGenericBehaviour<T1>(ref T1 data)
        {
            string behaviour = "";
            if (data is Animal)
            { 
            Animal animal = data as Animal;
                AnimalType type = (AnimalType)animal[3];
                switch (type)
                {
                        case AnimalType.None:
                        behaviour = "None";
                            break;
                        case AnimalType.Human:
                        behaviour = "Talks";
                            break;
                        case AnimalType.Horse:
                        behaviour = "sleepStand";
                            break;
                        case AnimalType.Cat:
                        behaviour = "lazy";
                            break;
                        case AnimalType.Dog:
                        behaviour = "barking";
                            break;
                        default:
                        behaviour = "Unkwon";
                            break;
                }

             

            }
               return behaviour;
        }
    }
}
