﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick,", 4, 160);

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven",buick.Brand);
            }

            Console.WriteLine("================================");

            IElectronicDevice Tv = TVRemote.GetDevice();
            PowerButton powerButtn = new PowerButton(Tv);

            powerButtn.Execute();
            powerButtn.Undo();

            Console.ReadLine();
        }
    }
}
