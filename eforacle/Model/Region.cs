// <copyright file="Region.cs" company="Translation Centre for the Bodies of the European Union">
//  Copyright (c) 2013 All Rights Reserved
// </copyright>
  
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFOracle.Model
{
    public class Region
    {
        public virtual decimal id { get; set; }

        public virtual string Name { get; set; }

        public virtual List<Country> Countries { get; set; }
    }
}