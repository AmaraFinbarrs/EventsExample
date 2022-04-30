using System;
using ClassLibrary1;

namespace EventsExample
{
    class Program
    {
        static void Main()
        {
            //create obj of Subscriber class
            Subscriber subscriber = new Subscriber();

            //create obj of Publisher class
            Publisher publisher = new Publisher();

            //handle the event or subscribe to event
            //publisher.myEvent += subscriber.Add;
            publisher.myEvent += (a, b) =>
            {
                int c = a + b;
                Console.WriteLine(c);
            };
           

            //invoke the event
            publisher.RaiseEvent(10, 20);
            publisher.RaiseEvent(50, 20);
            publisher.RaiseEvent(900, 20);

            Console.ReadKey();
        }
    }
}
