using CommondityPricer.ThirdParties;

namespace CommondityPricer
{
    public class PricingTask
    {
        private readonly IProvideMarketData _marketDataProvider;
        private readonly IPublishPrice _pricePublisherAdapter;

        public PricingTask() : this(new MarketDataRetrieverAdatper(), new PricePublisherAdapter())
        {
        }

        public PricingTask(IProvideMarketData marketDataProvider, IPublishPrice pricePublisherAdapter)
        {
            _marketDataProvider = marketDataProvider;
            _pricePublisherAdapter = pricePublisherAdapter;
        }

        public void PriceAndPublish(string underlying)
        {
            double yesterdayPrice = _marketDataProvider.GetClose(underlying);

            //FIXME en fait, ça devrait être + 2 et non pas + 1
            double todayPrice = yesterdayPrice + 1 + 1;
            _pricePublisherAdapter.Publish(todayPrice);
        }
    }
}
