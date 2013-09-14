// <copyright file="EFOracleInitialization.cs" company="Translation Centre for the Bodies of the European Union">
//  Copyright (c) 2013 All Rights Reserved
// </copyright>

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFOracle.Model;

namespace EFOracle.Data
{
    // not supported by oracle
    public class EFOracleInitialization : DropCreateDatabaseAlways<EFOracleContext>
    {
        protected override void Seed(EFOracleContext context)
        {
            //create sample data and attach it to the context.
            var regions = new List<Region>
            {
                new Region
                {
                    id = 0,
                    Name = "Europe"
                },
                new Region
                {
                    id = 1,
                    Name = "America"
                },
                new Region
                {
                    id = 2,
                    Name = "MiddleEast"
                }
            };
            regions.ForEach(x => context.Region.Add(x));

            var countries = new List<Country>
            {
                new Country
                {
                    id = 0,
                    Name = "Belgium",
                    Region = regions[0]
                },
                new Country
                {
                    id = 1,
                    Name = "France",
                    Region = regions[0]
                },
                new Country
                {
                    id = 2,
                    Name = "Germany",
                    Region = regions[0]
                },
                new Country
                {
                    id = 3,
                    Name = "United States",
                    Region = regions[1]
                },
                new Country
                {
                    id = 4,
                    Name = "Canada",
                    Region = regions[1]
                },
                new Country
                {
                    id = 5,
                    Name = "Israel",
                    Region = regions[2]
                }
            };
            countries.ForEach(x => context.Country.Add(x));

            new List<City>
            {
                new City
                {
                    id = 0,
                    Name = "Brussels",
                    Country = countries[0]
                },
                new City
                {
                    id = 1,
                    Name = "Paris",
                    Country = countries[1]
                },
                new City
                {
                    id = 2,
                    Name = "Berlin",
                    Country = countries[2]
                },
               new City
                {
                    id = 3,
                    Name = "Washington",
                    Country = countries[3]
                },
               new City
                {
                    id = 4,
                    Name = "Edmonton",
                    Country = countries[4]
                },
                new City
                {
                    id = 5,
                    Name = "Jerusalem",
                    Country = countries[5]
                },
            }.ForEach(x => context.Cities.Add(x));

            base.Seed(context);
        }
    }

    public class EFOracleSeedData : IDatabaseInitializer<EFOracleContext>
    {
        /// <summary>
        /// Initializes the database.
        /// </summary>
        /// <param name="context">The context.</param>
        public void InitializeDatabase(EFOracleContext context)
        {
            //create sample data and attach it to the context.
            var regions = new List<Region>
            {
                new Region
                {
                    id = 0,
                    Name = "Europe"
                },
                new Region
                {
                    id = 1,
                    Name = "America"
                },
                new Region
                {
                    id = 2,
                    Name = "MiddleEast"
                }
            };
            regions.ForEach(x => context.Region.Add(x));

            new List<Country>
            {
                new Country
                {
                    id = 0,
                    Name = "Belgium",
                    Region = regions[0]
                },
                new Country
                {
                    id = 1,
                    Name = "France",
                    Region = regions[0]
                },
                new Country
                {
                    id = 2,
                    Name = "Germany",
                    Region = regions[0]
                },
                new Country
                {
                    id =3,
                    Name = "United States",
                    Region = regions[1]
                },
                new Country
                {
                    id = 4,
                    Name = "Canada",
                    Region = regions[1]
                },
                new Country
                {
                    id = 5,
                    Name = "Israel",
                    Region = regions[2]
                }
            }.ForEach(x => context.Country.Add(x));
            context.Database.ExecuteSqlCommand("delete from \"COUNTRIES\"");
            context.Database.ExecuteSqlCommand("delete from  \"REGIONS\"");
            context.SaveChanges();
        }
    }
}