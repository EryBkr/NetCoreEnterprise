using EnterpriseProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
