using CrudSlice.Model;
using Foundation.DataObject;
using Foundation.DataObjectClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSlice.ClientCore
{

    public class TemplateClassDtoHttpApiService : HttpApiServiceWrapper<TemplateClassDTO, string>, ITemplateClassDtoEntityService
    {

        public TemplateClassDtoHttpApiService(ITemplateClassDtoHttpService api) : base(api)
        {
            _api = api;
        }

        Task<IQueryable<TemplateClassDTO>> IEntityObjectService<TemplateClassDTO, string>.GetAllAsQueryable()
        {
            throw new NotImplementedException();
        }
    }
}
