// <copyright file="Program.cs" company="Translation Centre for the Bodies of the European Union">
//  Copyright (c) 2013 All Rights Reserved
// </copyright>

using System;
using System.Linq;
using EFOracle.Data;

namespace EFOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.Entity.Database.SetInitializer(new EFOracleSeedData());
            using (EFOracleContext context = new EFOracleContext())
            {
                foreach (var r in context.Region)
                {
                    Console.WriteLine("Region {0} with id {1} and {2} countries", r.Name, r.id, r.Countries.Count());
                }
            }
        }
    }
}