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
            publisher.myEvent += (a) =>
            {
                return a >= 0;
            };
           

            //invoke the event
            Console.WriteLine(publisher.RaiseEvent(10));
            Console.WriteLine(publisher.RaiseEvent(-50));
            Console.WriteLine(publisher.RaiseEvent(4));

            Console.ReadKey();
        }
    }
}
