using ServiceBackendData.Entities;
using ServiceBackendData.Entities.ClassEntitiesDTO;
using ServiceBackendData.Entities.MethodExtension;
using ServiceBackendData.Logic.ClassLogic;
using System.Collections.Generic;
using System.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    ProductLogic productLogic = new ProductLogic();
    
    public IEnumerable<ProductDTO> GetAll()
    {
        var buffer = productLogic.GetAll();
        return buffer.Select(x => x.ToDTO()).Where(x => x.Available == true);
    }
}
