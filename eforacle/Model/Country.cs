// <copyright file="Country.cs" company="Translation Centre for the Bodies of the European Union">
//  Copyright (c) 2013 All Rights Reserved
// </copyright>

using System;
using System.Linq;

namespace EFOracle.Model
{
    public class Country
    {
        public virtual decimal id { get; set; }

        public virtual string Name { get; set; }

        public virtual Region Region { get; set; }
    }
}