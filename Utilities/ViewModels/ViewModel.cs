namespace KnTenshi.Utilities.ViewModels
{
	using System;
	using System.ComponentModel;
	using KnTenshi.Utilities;
	using KnTenshi.Utilities.ViewModels.Interfaces;

	public abstract class ViewModel : DisposableBase, IViewModel, INotifyPropertyChanged, IDisposable
	{
		#region Protected Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ViewModel"/> class.
		/// </summary>
		protected ViewModel()
			: base()
		{
		}

		#endregion

		#region Public Events

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		#endregion
	}
}
