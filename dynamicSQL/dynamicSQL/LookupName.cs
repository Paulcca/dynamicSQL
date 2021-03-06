﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicSQL
{
    public class LookupName
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ColumnName> ColumnNames { get; set; }
    }
}
