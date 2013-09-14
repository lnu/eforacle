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
            System.Data.Entity.Database.SetInitializer(new EFOracleInitialization());
            using (EFOracleContext context = new EFOracleContext())
            {
                foreach (var r in context.Region)
                {
                    Console.WriteLine("Region {0} with id {1} and {2} countries", r.Name, r.id, r.Countries.Count());
                    foreach (var co in r.Countries)
                    {
                        Console.WriteLine("Country {0} with id {1} and {2} cities", co.Name, co.id, co.Cities.Count());
                        foreach (var c in co.Cities)
                        {
                            Console.WriteLine("City {0} with id {1} and Population {2}", c.Name, c.id, c.Population);
                        }
                    }
                }
            }
        }
    }
}