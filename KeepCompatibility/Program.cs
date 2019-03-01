using CommondityPricer;

namespace KeepCompatibility
{
    /// <summary>
    /// Classe à ne pas modifier. Ça doit compiler et fonctionner comme avant (aux corrections de bug près)
    /// </summary>
    class Program
    {
        static void Main()
        {
            var massPricerPublisher = new MassPricerPublisher();
            massPricerPublisher.PriceAndPublishEverything();
        }
    }
}
