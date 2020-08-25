using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class DynamicArray
    {
        #region DataFeilds / state/ fields
        int[] buffer;
        #endregion

        #region Constrcutors
        internal DynamicArray()
        {
            buffer = new int[3];
        }
        internal DynamicArray(int capacity)
        {
            buffer = new int[capacity];
        }

        #endregion

        #region Behaviors
        //internal void  Set_Item(DynamicArray this,int item,int index)
        //internal void Set_Item(int item, int index)
        //{

        //    //check for overflow
        //    if (index >= this.buffer.Length)
        //    {
        //        int[] tempBuffer = new int[index + 10];
        //        System.Diagnostics.Stopwatch _watch = new System.Diagnostics.Stopwatch();
        //        _watch.Start();
        //        for (int i = 0; i < buffer.Length; i++)
        //        {
        //            tempBuffer[i] = buffer[i];
        //        }
        //        _watch.Stop();
        //        Console.WriteLine(_watch.ElapsedTicks);


        //        buffer = tempBuffer;

        //    }
        //    buffer[index] = item;
        //}
        ////internal int Get_Item(DynamicArray this,int index)
        //internal int Get_Item(int index)
        //{
        //    return this.buffer[index];

        //}
        #endregion

        #region indexer
        internal int this[int index]
        {
            get { return this.buffer[index]; }
            set
            { //check for overflow
                if (index >= this.buffer.Length)
                {
                    int[] tempBuffer = new int[index + 10];
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

    }
}
