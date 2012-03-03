using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SamuraiWars.Data;
using SamuraiWars.Model;

namespace SamuraiWars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's see how to add a castle to our database using Entity Framework
            Castle castle = new Castle
                                {
                                    Name = "The Mysterious Castle",
                                    Description =
                                        "An ancient magic castle that only appears in our world once every hundred years.",
                                    Location = "Unknwown"
                                };
            // The first time you run this a database will be created for you from the domain model. Isn't that awesome!
            // By default, Entity Framework will create a SamuraiWars database within your SQL Server Express instance.
            using (SamuraiWarsContext context = new SamuraiWarsContext())
            {
                context.Castles.Add(castle);
                context.SaveChanges();
            }
        }
    }
}
