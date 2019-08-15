using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Television : IElectronicDevice
    {
        public int volume { get; set; }


        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The Tv is On");
        }

        public void VolumeDown()
        {
            if(volume!=0)
                volume--;
            Console.WriteLine($"The TV Volume is at {volume}");
        }

        public void VolumeUp()
        {
            if(volume!=100)
                volume++;
            Console.WriteLine($"The TV Volume is at {volume}");
        }
    }
}
