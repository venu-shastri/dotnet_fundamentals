 public class SearchTask
    {
        public void Search()
        {

        }
    }

    public class ThreadStartCommand
    {
        SearchTask _taskObject;
        public ThreadStartCommand(SearchTask taskObject)
        {
            this._taskObject = taskObject;
        }
        public void Invoke()
        {
            this._taskObject.Search();
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
            ThreadStartCommand _command = new ThreadStartCommand(_searchTask);
            Thread _t1 = new Thread(_command);
            _t1.Start();
        }
    }
