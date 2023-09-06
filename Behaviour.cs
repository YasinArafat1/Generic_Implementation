using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public class Behaviour
    {
        string _Name;
        string _GenericBehaviour;
        string _TypeSpecificBehaviour;

        public Behaviour(string name,string genericbehaviour,string typespecificationbehaviour)
        {
            _Name = name;
            _GenericBehaviour = genericbehaviour;
            _TypeSpecificBehaviour = typespecificationbehaviour;
        }

        public string Name { get => _Name; set => _Name = value; }
        public string GenericBehaviour { get => _GenericBehaviour; set => _GenericBehaviour = value; }
        public string TypeSpecificBehaviour { get => _TypeSpecificBehaviour; set => _TypeSpecificBehaviour = value; }

    }
}
