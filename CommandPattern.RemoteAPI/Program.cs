using CommandPattern.RemoteAPI.Client;
using CommandPattern.RemoteAPI.Command;
using CommandPattern.RemoteAPI.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            var fan = new Fan();
            var fanOnCommand = new FanOnCommand(fan);
            var fanOffCommand = new FanOffCommand(fan);

            var remoteInvoker = new RemoteInvoker(new List<ICommand>() { fanOnCommand,fanOffCommand });

            remoteInvoker.ExecuteAction(0);
            remoteInvoker.ExecuteAction(1);

            Console.ReadKey();
        }
    }
}
