
namespace MessageMicroservice.Api
{
    public class OrderConnector : IOrderConnector
    {
        public Task<OrderInfo> GetNextOrder()
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrder(OrderInfo order)
        {
            throw new NotImplementedException();
        }
    }
}
