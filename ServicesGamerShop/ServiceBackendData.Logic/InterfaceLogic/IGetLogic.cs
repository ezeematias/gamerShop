using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Logic.InterfaceLogic
{
    interface IGetLogic<T>
    {
        IEnumerable<T> GetAll();
    }
}
