using System.Collections.Generic;

namespace CommondityPricer
{
    public class Perimeter
    {
        public static IEnumerable<string> GetPerimeter()
        {
            //FIXME : ne prendre en compte que les sousjacents commençant par un C
            return AllUnderlyings.GetAll();
        }
    }
}
