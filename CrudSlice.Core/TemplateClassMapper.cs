using CrudSlice.Entity;
using CrudSlice.Model;
using Foundation.DataObject;
using Riok.Mapperly.Abstractions;

namespace CrudSlice.Core
{
    [Mapper]
    public partial class TemplateClassMapper : IEntityObjectMapper<TemplateClass, TemplateClassDTO>
    {
        public partial void MapDtoToTarget(TemplateClassDTO vm, TemplateClass t);

        public partial TemplateClass MapIn(TemplateClassDTO data);

        public partial List<TemplateClass> MapInList(List<TemplateClassDTO> data);

        public partial TemplateClassDTO MapOut(TemplateClass data);

        public partial List<TemplateClassDTO> MapOutList(List<TemplateClass> data);
    }
}

