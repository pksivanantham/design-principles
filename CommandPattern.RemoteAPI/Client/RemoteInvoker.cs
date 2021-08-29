using CommandPattern.RemoteAPI.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.RemoteAPI.Client
{
    public class RemoteInvoker
    {
        private List<ICommand> _command = new List<ICommand>();
        public RemoteInvoker()
        {

        }

        public RemoteInvoker(List<ICommand> command) => _command.AddRange(command);

        public void AddCommand(ICommand command) => _command.Add(command);


        public void ExecuteAction(int i) => _command[i].Execute();


    }
}
