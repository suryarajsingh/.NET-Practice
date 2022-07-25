using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{
    public delegate string WishingDelegate(string str);
    class EventsEg2
    {
        public event WishingDelegate wishevent;
        public event WishingDelegate justname;

        public EventsEg2()
        {
            this.wishevent += new WishingDelegate(this.WishUser);
            this.justname += new WishingDelegate(this.DisplayName);
        }

        public string WishUser(string username)
        {
            return "Welcome" + " " + username;
        }

        public string DisplayName(string name)
        {
            return name;
        }

        static void Main()
        {
            EventsEg2 ec2 = new EventsEg2();
            Console.WriteLine(ec2.wishevent("Banurekha"));
            Console.WriteLine(ec2.justname("FIS Global"));

            Console.Read();

        }
    }
}
