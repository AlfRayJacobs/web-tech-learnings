using System.Text;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare("learner", false, false, false, null);

while (true)
{
    Console.WriteLine("\nEnter message to send:");
    var message = Console.ReadLine();

    if (string.IsNullOrEmpty(message))
        continue;

    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish(string.Empty, "learner", null, body);
    Console.WriteLine($"Sent {message}");
}
