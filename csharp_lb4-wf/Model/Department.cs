using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lb4_wf.Model
{
    public class Department
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        public string Name { get; set; }

        public Department(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public bool IsValid()
        {
            var validationContext = new ValidationContext(this, null, null);
            var results = new List<ValidationResult>();
            return Validator.TryValidateObject(this, validationContext, results, true);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

}
