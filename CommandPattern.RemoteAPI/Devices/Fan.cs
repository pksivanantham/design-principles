using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteAPI.Devices
{
    public class Fan
    {

        public void On() => Console.WriteLine($"{nameof(Fan)} Switched on");
        public void Off() => Console.WriteLine($"{nameof(Fan)} Switched off");
    }
}
