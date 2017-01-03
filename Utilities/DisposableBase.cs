namespace KnTenshi.Utilities
{
	using System;

	/// <summary>
	/// Provides a base class with a built in implementation of <see cref="IDisposable"/>.
	/// </summary>
	public abstract class DisposableBase : object, IDisposable
	{
		#region Private Mutable Fields

		/// <summary>
		/// A value indicating whether this instance has been disposed.
		/// </summary>
		private bool isDisposed;

		#endregion

		#region Protected Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DisposableBase"/> class.
		/// </summary>
		protected DisposableBase()
			: base()
		{
			this.isDisposed = false;
		}

		#endregion

		#region Protected Get Only Properties

		/// <summary>
		/// Gets a value indicating whether this instance has been disposed.
		/// </summary>
		protected bool IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		#endregion

		#region Methods

		#region Public Methods

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Protected Methods

		/// <summary>
		/// When overridden in a child class, this disposes of all managed resources.
		/// </summary>
		protected virtual void DisposeOfManagedResources()
		{
		}

		/// <summary>
		/// When overridden in a child class, this disposes of all unmanaged resources.
		/// </summary>
		protected virtual void DisposeOfUnmanagedResources()
		{
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Disposes of the unmanaged resources and conditionally disposes of managed resources.
		/// </summary>
		/// <param name="isDisposing">A value indicating whether to dispose of the managed resources.</param>
		private void Dispose(bool isDisposing)
		{
			if (this.isDisposed)
			{
				return;
			}

			this.isDisposed = true;

			if (isDisposed)
			{
				this.DisposeOfManagedResources();
			}

			this.DisposeOfUnmanagedResources();
		}

		#endregion

		#endregion
	}
}
