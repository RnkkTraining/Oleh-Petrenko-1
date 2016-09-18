using System;
using System.Collections.Generic;
using SortApp.BL;

namespace SortApp.ViewModel
{
    /// <summary>
    /// Represents creator towards the name of algorithm accordance kind for sorting algorithms.
    /// </summary>
    /// <owner>Oleh Petrenko</owner>
    public static class SortingAlgorithmNameAccordanceKindCreator
    {
        /// <summary>
		/// Returns dictionary with name and kind for sorting algorithms.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
        public static Dictionary<string, SortingAlgorithmKind> CreateDictionary()
        {
            return new Dictionary<string, SortingAlgorithmKind>
            {
                {"Bubble sort", SortingAlgorithmKind.Bubble},
                {"Insertion sort", SortingAlgorithmKind.Insertion},
                {"Selection sort", SortingAlgorithmKind.Selection},
                {"Quicksort", SortingAlgorithmKind.Quick}
            };
        }
    }
}
