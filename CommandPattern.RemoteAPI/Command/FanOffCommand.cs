using CommandPattern.RemoteAPI.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteAPI.Command
{
    public class FanOffCommand : ICommand
    {
        private Fan _fan;
        public FanOffCommand(Fan fan) => _fan = fan;
        public void Execute() => _fan.Off();
    }
}
