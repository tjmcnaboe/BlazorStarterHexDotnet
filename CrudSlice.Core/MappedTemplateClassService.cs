using CrudSlice.Entity;
using CrudSlice.Model;
using Foundation.DataObject;
using Foundation.DataObjectServer;
using Microsoft.EntityFrameworkCore;

namespace CrudSlice.Core
{
    public class MappedTemplateClassService<db> : MappedEntityService<TemplateClassDTO, db, string, TemplateClass>, ITemplateClassDtoEntityService where db : DbContext
    {
        public MappedTemplateClassService(IDbContextFactory<db> factory, IEntityObjectMapper<TemplateClass, TemplateClassDTO> mapper) : base(factory, mapper)
        {
        }

        public override string GetKeyFromVm(TemplateClassDTO input)
        {
            return input.Id;
        }

    }
}

