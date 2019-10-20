using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EnterpriseProject.Project.Entities.Concrete
{
    public class ShippingDetails
    {
        public string FirstName { get; set; }
        
        [Required(ErrorMessage ="Sorun Var"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Range(15,75,ErrorMessage ="Sorun Var")]
        public int Age { get; set; }
    }
}
