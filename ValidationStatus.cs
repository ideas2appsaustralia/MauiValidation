using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiValidation
{
	public class ValidationStatus : ObservableObject
	{
		private bool hasError;
		private string error;

		public bool HasError
		{
			get => this.hasError;
			set => SetProperty(ref this.hasError, value);
		}

		public string Error
		{
			get => this.error;
			set => SetProperty(ref this.error, value);
		}

		public ValidationStatus()
		{
		}

		public ValidationStatus(bool hasError, string error)
		{
			this.hasError = hasError;
			this.error = error;
		}
	}
}
