using System;


namespace ClassLibrary1
{

    //Publisher
    public class Publisher
    {
        //step 1: create event
        public event Func<int, int, int> myEvent;

        public int RaiseEvent(int a, int b)
        {
            //step 2: raise event
            if (this.myEvent != null)
            {
                int x = this.myEvent(a, b);
                return x;
            }
            return 0;
        }
    }
}
