using ServiceBackendData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBackendData.Logic.ClassLogic
{
    public class BaseLogic
    {
        protected readonly gamerShopContext context;

        public BaseLogic()
        {
            context = new gamerShopContext();
        }
    }
}
