using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ_Sample
{
    public class Consumer
    {
        private readonly RabbitMQService _rabbitMQService;
        public string _queue;

        public Consumer(string queueName)
        {
            _rabbitMQService = new RabbitMQService();

            var connection = _rabbitMQService.GetRabbitMQConnection();
            {



                var channel = connection.CreateModel();
                {


                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var _queue = Encoding.UTF8.GetString(body);


                        this._queue = _queue;
                        
                        

                    };

                    channel.BasicConsume(queueName, false, consumer);
                    //Console.ReadLine();

                }
            }




        }

        public string GetMessage()
        {
            return _queue;
        }

    }
}
