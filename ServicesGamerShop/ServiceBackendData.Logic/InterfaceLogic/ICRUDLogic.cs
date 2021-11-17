using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Logic.InterfaceLogic
{
    interface ICRUDLogic <T>
    {
        void Add(T addItem);
        void Delete(int id);
        void Update(T updateItem);
    }
}
