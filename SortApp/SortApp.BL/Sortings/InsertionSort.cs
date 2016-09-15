using System;

namespace SortApp.BL.Sortings
{
    /// <summary>
    /// Implementing insertion sort algorithm
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public sealed class InsertionSort<T> : Sorter<T> where T : IComparable<T>
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
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; (j > 0) && (arr[j].CompareTo(arr[j - 1]) < 0); j--)
                {
                    Swap(ref arr[j], ref arr[j - 1]);
                }
            }
        }
    }
}
