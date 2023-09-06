using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public class TypeSpecificBehaviour<T> : ITypeSpecificationBehaviour<T>
    {
        public string GetTypeSpecificationBehaviour<T1>(ref T1 data) where T1 : Animal
        {
            string behaviour = "";
            if (data != null)
            {
                AnimalType type = (AnimalType)data[3];
                switch (type)
                {
                  case AnimalType.None:
                        behaviour = "None";
                        break;
                    case AnimalType.Human:
                        behaviour = "Inteligent";
                        break;
                    case AnimalType.Cat:
                        behaviour = "Lazy";
                        break;
                    case AnimalType.Dog:
                        behaviour = "Faithful";
                        break;
                    case AnimalType.Horse:
                        behaviour = "Gada";
                        break;

                }

            }
            return behaviour;
        }
    }
}
