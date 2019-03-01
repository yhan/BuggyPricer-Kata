using System.Windows.Forms;

namespace CommondityPricer.ThirdParties
{
    /// <summary>
    /// Interdiction de toucher à cette classe. C'est une tièrce partie
    /// </summary>
    public class PricePublisher
    {
        private PricePublisher()
        {
        }

        public static PricePublisher Instance { get; } = new PricePublisher();

        public void Publish(double price)
        {
            MessageBox.Show("T'as publié un prix bidon en prod, le trader est furieux !", "Et paf !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
