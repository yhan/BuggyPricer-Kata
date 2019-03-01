using System.Collections.Generic;

namespace CommondityPricer
{
    public class Perimeter
    {
        public Perimeter()
        {
            
        }

        public static IEnumerable<string> GetPerimeter()
        {
            return GetPerimeter(new AllUnderlyings());
        }

        public static IEnumerable<string> GetPerimeter(AllUnderlyings allUnderlyings)
        {
            //FIXME : ne prendre en compte que les sousjacents commençant par un C

            return allUnderlyings.GetAllProducts();
        }
    }
}
