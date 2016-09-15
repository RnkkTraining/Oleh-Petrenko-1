using System;

namespace SortApp.BL.Sortings
{
    /// <summary>
    /// Abstact for sorting
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public abstract class Sorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Implementing sorting algorithm
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param>
        /// Incoming array for sorting
        /// </param>
        public abstract void Sort(T[] arr);

        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param name="item1">
        /// First element for swap
        /// </param>
        /// <param name="item2">
        /// Secend element for swap
        /// </param>
        protected void Swap(ref T item1, ref T item2)
        {
            T tmp = item1;
            item1 = item2;
            item2 = tmp;
        }
    }
}