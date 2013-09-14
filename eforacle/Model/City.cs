using System;
using System.Collections.Generic;
using System.Linq;

namespace EFOracle.Model
{
    public class City
    {
        public virtual decimal id { get; set; }

        public virtual string Name { get; set; }

        public virtual long Population { get; set; }

        public virtual Country Country { get; set; }

    }
}