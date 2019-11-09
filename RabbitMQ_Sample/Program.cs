using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ_Sample
{
    class Program
    {

        private static readonly string _queueName = "Sezgin";
        private static Publisher _publisher;
        private static Consumer _consumer;
        static void Main(string[] args)
        {

            //_publisher = new Publisher(_queueName, "Merhaba Dünya");
            //_publisher = new Publisher(_queueName, "Merhaba Dünya2");
            //_publisher = new Publisher(_queueName, "Merhaba Dünya3");
            //_publisher = new Publisher(_queueName, "Merhaba Dünya4");

            _consumer = new Consumer(_queueName);

            Console.WriteLine("gelen:" + _consumer._queue);
            Console.ReadLine();

        }
    }
}
