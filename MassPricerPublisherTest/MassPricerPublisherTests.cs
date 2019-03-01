namespace MassPricerPublisherTests
{
    using System.Linq;
    using CommondityPricer;
    using CommondityPricer.ThirdParties;
    using NSubstitute;
    using NUnit.Framework;

    public class MassPricerPublisherShould
    {

        [Test]
        public void Can_price_and_publish()
        {
            var marketDataProvider= NSubstitute.Substitute.For<IProvideMarketData>();
            marketDataProvider.GetClose(Arg.Any<string>()).Returns(1);
            
            IPublishPrice pricePublisher = Substitute.For<IPublishPrice>();

            var allUnderlyings = Substitute.For<AllUnderlyings>();
            var products = new[] {"Cacao", "Sucre", "Petrole", "Carcasses de porc", "Or", "Cuivre"}.Where(x => x.StartsWith("C"));
            allUnderlyings.GetAllProducts().Returns(products);


            var massPricerPublisher = new MassPricerPublisher(allUnderlyings);
            massPricerPublisher.PriceAndPublishEverything(marketDataProvider, pricePublisher);

            pricePublisher.Received(products.Count()).Publish(3);
        }
    }
}
