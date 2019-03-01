using System;
using System.Collections.Generic;
using System.Threading;

namespace CommondityPricer
{
    public static class AllUnderlyings
    {
        public static IEnumerable<string> GetAll()
        {         
            Thread.Sleep(5000); //Les accès à la base de données sont super lents
            return new[] { "Cacao", "Sucre", "Petrole", "Carcasses de porc", "Or", "Cuivre" };
        }
    }
}
