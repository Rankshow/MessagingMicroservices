
//using Azure.Storage.Queues;
//using MessageMicroservice.Api.Model;

//namespace MessageMicroservice.Api.Services
//{
//    public class OrderQueueConnector : IOrderConnector
//    {
//        readonly ILogger<OrderQueueConnector> _logger;
//        readonly QueueClient _orderQueueClient;

//        public OrderQueueConnector(QueueClient orderQueueClient, ILogger<OrderQueueConnector> logger)
//        {
//            _logger = logger;
//            _orderQueueClient = orderQueueClient;

//            var connectionString = "AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;DefaultEndpointsProtocol=http;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";
//            var queueOpts = new QueueClientOptions
//            {
//                MessageEncoding = QueueMessageEncoding.Base64
//            };

//            _orderQueueClient = new QueueClient(connectionString, "customer-order", queueOpts);
//            _orderQueueClient.CreateIfNotExists();
//        }

//        public async Task<OrderInfo> GetNextOrder()
//        {
//            _logger.LogInformation("Getting all orders...");
//            var response = await _orderQueueClient.ReceiveMessageAsync();

//            if (response.Value != null)
//            {
//                var order = response.Value.Body.ToObjectFromJson<OrderInfo>();
//                order.QueueMessageId = response.Value.MessageId;
//                order.QueuePopRecieipt = response.Value.PopReceipt;

//                return order;
//            }

//            return null;
//        }

//        public async Task RemoveOrder(OrderInfo order)
//        {
//            await _orderQueueClient.DeleteMessageAsync(order.QueueMessageId, order.QueuePopRecieipt);
//        }
//    }
//}
