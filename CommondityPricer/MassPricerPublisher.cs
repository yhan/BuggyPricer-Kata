namespace CommondityPricer
{
    using ThirdParties;

    /// <summary>
    /// Cette classe est utilisée par d'autres. Il ne faut pas casser la compatibilité
    /// </summary>
    public class MassPricerPublisher
    {
        private readonly AllUnderlyings _allUnderlyingsProvider;

        public MassPricerPublisher(): this(new AllUnderlyings())
        {
        }

        public MassPricerPublisher(AllUnderlyings allUnderlyingsProvider)
        {
            _allUnderlyingsProvider = allUnderlyingsProvider;
        }

        public void PriceAndPublishEverything()
        {
            PriceAndPublishEverything(new MarketDataRetrieverAdatper(), new PricePublisherAdapter());
        }

        public void PriceAndPublishEverything(IProvideMarketData marketDataProvider, IPublishPrice pricePublisher)
        {
            var underlyings = Perimeter.GetPerimeter(_allUnderlyingsProvider);
            var pricingTask = new PricingTask(marketDataProvider, pricePublisher);

            foreach (var underlying in underlyings)
            {
                pricingTask.PriceAndPublish(underlying);
            }
        }
    }
}
