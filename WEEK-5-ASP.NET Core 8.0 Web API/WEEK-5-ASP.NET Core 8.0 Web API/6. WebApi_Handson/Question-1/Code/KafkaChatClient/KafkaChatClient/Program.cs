using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    const string topic = "chat-topic";
    const string bootstrapServers = "localhost:9092";

    static async Task Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string user = Console.ReadLine();

        var cancelSource = new CancellationTokenSource();

        // Start consumer in background
        Task consumerTask = Task.Run(() => StartConsumer(cancelSource.Token, user));

        // Start sending messages
        var config = new ProducerConfig { BootstrapServers = bootstrapServers };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type your messages below (type 'exit' to quit):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input?.ToLower() == "exit")
            {
                cancelSource.Cancel();
                break;
            }

            string message = $"[{user}]: {input}";
            await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
        }

        await consumerTask;
    }

    static void StartConsumer(CancellationToken token, string currentUser)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = $"chat-group-{Guid.NewGuid()}",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(topic);

        try
        {
            while (!token.IsCancellationRequested)
            {
                var result = consumer.Consume(token);
                if (!result.Message.Value.StartsWith($"[{currentUser}]"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(result.Message.Value);
                    Console.ResetColor();
                }
            }
        }
        catch (OperationCanceledException)
        {
            consumer.Close();
        }
    }
}
