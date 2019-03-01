using System;
using System.Collections.Generic;
using System.Threading;

namespace CommondityPricer
{
    public class AllUnderlyings
    {
        public AllUnderlyings()
        {
        }
        
        // Introduce Instance Delegator
        public virtual IEnumerable<string> GetAllProducts()
        {
            return GetAll();
        }

        public static IEnumerable<string> GetAll()
        {         
            Thread.Sleep(5000); //Les accès à la base de données sont super lents
            return new[] { "Cacao", "Sucre", "Petrole", "Carcasses de porc", "Or", "Cuivre" };
        }
    }
}
