using System.Reflection.Emit;

namespace CrudSlice.Entity
{
    public class TemplateClass
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DOB { get; set; }



    }
}
