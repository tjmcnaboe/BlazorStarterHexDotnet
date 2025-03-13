using CrudSlice.Entity;
using CrudSlice.Model;
using Foundation.DataObject;
using Foundation.DataObjectController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrudSlice.Core
{


    [Route("api/[controller]")]
    [ApiController]
    public class TemplateClassController : GenericController<TemplateClassDTO, string>
    {
        public TemplateClassController(ITemplateClassDtoEntityService service) : base(service)
        {
            var x = 1;

        }

        public override Task<ActionResult<IEnumerable<TemplateClassDTO>>> GetAll()
        {
            return base.GetAll();
        }

    }
}

