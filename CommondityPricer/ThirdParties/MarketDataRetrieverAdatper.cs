namespace CommondityPricer.ThirdParties
{
    using System;
    using System.Configuration;
    using System.Windows.Forms;

    public interface IProvideMarketData
    {
        double GetClose(string underlying);
    }

    public class MarketDataRetrieverAdatper : IProvideMarketData
    {
        private MarketDataRetriever _marketDataRetriever;

        public MarketDataRetrieverAdatper()
        {
            _marketDataRetriever = new MarketDataRetriever();
        }

        public double GetClose(string underlying)
        {

            return _marketDataRetriever.GetClose(underlying);
        }
    }
}