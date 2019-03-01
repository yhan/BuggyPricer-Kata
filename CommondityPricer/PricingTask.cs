using CommondityPricer.ThirdParties;

namespace CommondityPricer
{
    public class PricingTask
    {
        private readonly MarketDataRetriever _marketDataRetriever;

        public PricingTask()
        {
            _marketDataRetriever = new MarketDataRetriever();
        }

        public void PriceAndPublish(string underlying)
        {
            double yesterdayPrice = _marketDataRetriever.GetClose(underlying);
            //FIXME en fait, ça devrait être + 2 et non pas + 1
            double todayPrice = yesterdayPrice + 1;
            PricePublisher.Instance.Publish(todayPrice);
        }
    }
}
