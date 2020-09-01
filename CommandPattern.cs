using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAsAnArugment
{
    public class CommandSource
    {
       public void Operation(Command target) {

            target.Invoke();
        
        }
    }

    //Encapsulate Request
    public class Command
    {
        CommandTarget obj = new CommandTarget();
        public void Invoke()
        {
            obj.Task();
        }
    }
    class CommandTarget
    {
        public void Task() { }
    }
}
