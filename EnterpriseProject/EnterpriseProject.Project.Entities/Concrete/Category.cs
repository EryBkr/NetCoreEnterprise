﻿using EnterpriseProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseProject.Project.Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
