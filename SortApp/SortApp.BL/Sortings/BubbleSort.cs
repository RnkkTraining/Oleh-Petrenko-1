using System;

namespace SortApp.BL.Sortings
{
    /// <summary>
    /// Implementing bubble sort algorithm
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public sealed class BubbleSort<T> : Sorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Implementing sorting algorithm
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param>
        /// Incoming array for sorting
        /// </param>
        public override void Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
