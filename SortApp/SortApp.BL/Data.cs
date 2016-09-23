﻿using System;
using System.Collections.Generic;

namespace SortApp.BL
{
	/// <summary>
	/// Model object for sorting.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public sealed class Data
	{
		/// <summary>
		/// Gets or sets object id in ctorage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The Id in storage.
		/// </value>
		public int Id
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the list which contains all iterations.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// Dictionary which contains all iterations.
		/// </value>
		public List<Iteration> Iterations
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets name of array.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The array name as string.
		/// </value>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the original array as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The incoming array as string.
		/// </value>
		public string OriginalData
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the sorted array as string.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <value>
		/// The sorted array as string.
		/// </value>
		public string SortedData
		{
			get;
			set;
		}
	}
}
