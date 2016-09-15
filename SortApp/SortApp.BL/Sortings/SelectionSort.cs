using System;

namespace SortApp.BL.Sortings
{
    /// <summary>
    /// Implementing selection sort algorithm
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public sealed class SelectionSort<T> : Sorter<T> where T : IComparable<T>
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        min = j;
                    }
                }

                Swap(ref arr[i], ref arr[min]);
            }
        }
    }
}
