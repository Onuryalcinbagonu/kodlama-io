﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.Entities.Concretes
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }

    }
}
