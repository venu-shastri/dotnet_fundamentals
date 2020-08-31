 internal class DynamicArray<T>
    {
        
        #region DataFeilds / state/ fields - camel notation
        private T[] buffer;
        private int itemCount;
        #endregion

        #region Constrcutors
        internal DynamicArray()
        {
            buffer = new T[3];
        }
        internal DynamicArray(int capacity)
        {
            buffer = new T[capacity];
        }

        #endregion

        #region Behaviors - Pascal Notation
        
        #endregion

        #region indexer
        internal T this[int index]
        {
            get { return this.buffer[index]; }
            set
            { //check for overflow
                this.itemCount++;
                if (index >= this.buffer.Length)
                {
                    T[] tempBuffer = new T[index + 10];
                    System.Diagnostics.Stopwatch _watch = new System.Diagnostics.Stopwatch();
                    _watch.Start();
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        tempBuffer[i] = buffer[i];
                    }
                    _watch.Stop();
                    Console.WriteLine(_watch.ElapsedTicks);


                    buffer = tempBuffer;

                }
                buffer[index] = value;
            }
        }

        #endregion

        #region Properties
        internal int Length
        {
            get
            {
                return this.buffer.Length;
            }
        }
        internal int ItemCount
        {
            get
            {
                return this.itemCount;
            }
        }
        #endregion

    }
