using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericImplementations
{
    public interface IGenericBehaviour<T>
    {
        string GetGenericBehaviour<T>(ref T data);

    }
}
