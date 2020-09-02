 public class BinarySearch
    {
        public void Search(CommandForVoidReturnAndZeroArgumentMethods methodRef) {

            methodRef.Invoke();
        }
        public void Search(CommandForVoidAndOneBoolArgumentMethods methodRef)
        {

            methodRef.Invoke(true);
        }
    }

    public delegate void CommandForVoidReturnAndZeroArgumentMethods();
    //public class CommandForVoidReturnAndZeroArgumentMethods
    //{
    //    object targetObject;
    //    string methodName;
    //    public CommandForVoidReturnAndZeroArgumentMethods(object targetObject,string methodName)
    //    {
    //        this.targetObject = targetObject;
    //        this.methodName = methodName;
    //    }
    //    public void Invoke()
    //    {
    //        //reflection

    //        System.Reflection.MethodInfo method = this.targetObject.GetType().GetMethod(this.methodName);
    //        if(method.ReturnType==typeof(void) && method.GetParameters().Length == 0)
    //        {
    //            method.Invoke(targetObject, null);
    //            return;
    //        }
    //        throw new InvalidOperationException("Signature Mismatch");
    //    }
    //}

    public delegate void CommandForVoidAndOneBoolArgumentMethods(bool ascending);
    //public class CommandForVoidAndOneBoolArgumentMethods
    //{
    //    object targetObject;
    //    string methodName;
    //    public CommandForVoidAndOneBoolArgumentMethods(object targetObject, string methodName)
    //    {
    //        this.targetObject = targetObject;
    //        this.methodName = methodName;
    //    }
    //    public void Invoke(bool ascending)
    //    {
    //        //reflection

    //        System.Reflection.MethodInfo method = this.targetObject.GetType().GetMethod(this.methodName);
    //        if (method.ReturnType == typeof(void)
    //            && method.GetParameters().Length == 1 && 
    //            method.GetParameters()[0].ParameterType==typeof(Boolean))
    //        {
    //            method.Invoke(targetObject, new object[] { ascending });
    //            return;
    //        }
    //        throw new InvalidOperationException("Signature Mismatch");
    //    }
    //}
    public class SortAlgorithSuite
    {
        public void BubbleSort() { }
        public void InsertionSort() { }
        public void QuickSort() { }
        public void BubbleSortWithArg(bool ascending) { }
    }
    class SearchSuite
    {
        static void Main()
        {

            BinarySearch _search = new BinarySearch();
            SortAlgorithSuite _sortSuite = new SortAlgorithSuite();

            //new CommandForVoidReturnAndZeroArgumentMethods(_sortSuite, "BubbleSort");
            CommandForVoidReturnAndZeroArgumentMethods _fptr =
                new CommandForVoidReturnAndZeroArgumentMethods(_sortSuite.BubbleSort);
            _search.Search(_fptr);

            _fptr = new CommandForVoidReturnAndZeroArgumentMethods(_sortSuite.InsertionSort);
            _search.Search(_fptr);

            CommandForVoidAndOneBoolArgumentMethods _newptr =
                new CommandForVoidAndOneBoolArgumentMethods(_sortSuite.BubbleSortWithArg);
            _search.Search(_newptr);

        }
    }
