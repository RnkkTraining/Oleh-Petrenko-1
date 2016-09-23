using System;
using System.Collections.Generic;

namespace SortApp.BL.Repository
{
	/// <summary>
	/// Represents the interface of repository.
	/// </summary>
	/// <owner>Oleh Petrenko</owner>
	public interface IRepository<T>
	{
		/// <summary>
		/// Removes entity of the storage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="item">
		/// Entity for removing.
		/// </param>
		void Delete(T item);

		/// <summary>
		/// Creates new entity in the storage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="item">
		/// Entity for adding to storage.
		/// </param>
		void Create(T item);

		/// <summary>
		/// Returns all elements from storage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <returns>
		/// List which contains all elements from storage.
		/// </returns>
		List<T> GellAll();

		/// <summary>
		/// Returns entity from storage by Id.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="id">
		/// Entity identity in storage.
		/// </param>
		/// <returns>
		/// Entity from storage.
		/// </returns>
		T GetById(int id);

		/// <summary>
		/// Updates entity in the storage.
		/// </summary>
		/// <owner>Oleh Petrenko</owner>
		/// <param name="item">
		/// Entity for updating.
		/// </param>
		void Update(T item);
	}
}
