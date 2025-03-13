using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudSlice.Entity
{
    public class TemplateClassEntityConfiguration : IEntityTypeConfiguration<TemplateClass>
    {
        public void Configure(EntityTypeBuilder<TemplateClass> builder)
        {

        }
    }
}
