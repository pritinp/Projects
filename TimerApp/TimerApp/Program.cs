using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerApp
{
    class myApp
    {
        public static void Main()
        {
            Timer myTimer = new Timer();
            myTimer.Elapsed += new ElapsedEventHandler( DisplayTimeEvent );
            myTimer.Interval = 1000;
            myTimer.Start();

            while ( Console.Read() != 'q' )
            {
                ;    // do nothing...
            }
        }

        public static void DisplayTimeEvent( object source, ElapsedEventArgs e )
        {
            Console.Write("\r{0}", DateTime.Now);
        }
    }
}
