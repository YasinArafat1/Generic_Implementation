using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public interface ITypeSpecificationBehaviour<T> 
    {
        string GetTypeSpecificationBehaviour<T>(ref T data
            ) where T : Animal;//Generic Constraints
    }
}
