namespace CommondityPricer.ThirdParties
{
    public interface IPublishPrice
    {
        void Publish(double price);
    }

    /// <summary>
    /// Interdiction de toucher à cette classe. C'est une tièrce partie
    /// </summary>
    public class PricePublisherAdapter : IPublishPrice
    {
        public void Publish(double price)
        {
            PricePublisher.Instance.Publish(price);
        }
    }
}