using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading.Tasks;
namespace rbt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sender...");
            send();
        }

        private static void send()
        {
            string message = "start";
            while (message!="")
            {
             message = Console.ReadLine();
                var factory = new ConnectionFactory() { HostName = "localhost", Password = "guest", UserName = "guest" };
                IConnection conn = factory.CreateConnection();
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }
           
        }

       
    }
}
