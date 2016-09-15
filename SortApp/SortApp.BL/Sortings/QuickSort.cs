using System;

namespace SortApp.BL.Sortings
{
    /// <summary>
    /// Implementing quick sort algorithm
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public sealed class QuickSort<T> : Sorter<T> where T : IComparable<T>
    {
        /// <summary>
        /// Starting sorting algorithm
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param>
        /// Incoming array for sorting
        /// </param>
        public override void Sort(T[] arr)
        {
            this.QuickSortAlgorithm(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Implementing sorting algorithm
        /// </summary>
        /// <owner>Oleh Petrenko</owner>
        /// <param name="arr">
        /// Incoming array for sorting and array bounds
        /// </param>
        /// <param name="l">
        /// Left border of the array
        /// </param>
        /// <param name="r">
        /// Right border of the array
        /// </param>
        private void QuickSortAlgorithm(T[] arr, int l, int r)
        {
            int i, j;
            i = l;
            j = r;
            T middle = arr[(i + j) / 2];

            do
            {
                while (middle.CompareTo(arr[i]) > 0)
                    i++;
                while (middle.CompareTo(arr[j]) < 0)
                    j--;

                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i < j);

            if (i < r)
                QuickSortAlgorithm(arr, i, r);
            if (j > l)
                QuickSortAlgorithm(arr, l, j);
        }
    }
}
