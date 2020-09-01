
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAsAnArugment
{
    public class SortTask
    {
        public void Sort() { }
    }
    public class SearchTask
    {
        public void Search()
        {

        }
    }

    public class ThreadStartCommand
    {
        object  _taskObject;
        string methodName;
        public ThreadStartCommand(object taskObject,string methodName)
        {
            this._taskObject = taskObject;
            this.methodName = methodName;
        }
        public void Invoke()
        {
            //Query an object for its type details like its name , methods and fields @runtime
            //Discover Method existance in _targetobject 
            //Invoke

            //reflect _taskObject
           System.Type _classMetdata= _taskObject.GetType();
           System.Reflection.MethodInfo _methodMetadata= _classMetdata.GetMethod(this.methodName);
            if (_methodMetadata.GetParameters().Length == 0)
            {
                //Dynamic Method Invoke
                _methodMetadata.Invoke(this._taskObject, null);
            }

            
        }
    }
    public class Thread
    {
        ThreadStartCommand _command;

        public Thread(ThreadStartCommand command)
        {
            this._command = command;
        }
        public void Start()
        {
            this._command.Invoke();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SearchTask _searchTask = new SearchTask();
           
            ThreadStartCommand _command = new ThreadStartCommand(_searchTask,"Search");
            Thread _t1 = new Thread(_command);
            _t1.Start();

            SortTask _sortTask = new SortTask();
            ThreadStartCommand _newCommand = new ThreadStartCommand(_sortTask,"Sort");
            Thread t2 = new Thread(_newCommand);
        }
    }
}
