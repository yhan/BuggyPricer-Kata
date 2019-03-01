using System;
using System.Configuration;
using System.Windows.Forms;

namespace CommondityPricer.ThirdParties
{
    public class MarketDataRetriever
    {
        public double GetClose(string underlying)
        {
            if (ConfigurationManager.AppSettings["licence"] == null)
            {
                MessageBox.Show("Pas de licence !", "Licence pénible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ConfigurationErrorsException();
            }
            return (underlying.GetHashCode() * (new Random()).NextDouble());
        }
    }
}
