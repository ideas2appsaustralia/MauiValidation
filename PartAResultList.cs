using CommunityToolkit.Mvvm.ComponentModel;
using MauiValidations;
using System.Runtime.CompilerServices;

namespace MauiValidation {
	public partial class PartAResultList : ObservableValidator {

		[ObservableProperty]
		[GreaterThan(nameof(PressDropSpec))]
		public double? pressDropResult;
		partial void OnPressDropResultChanged(double? value) {
			ClearErrors();
			SetProperty(ref this.pressDropResult, value, true);
			ValidateAllProperties();
			OnPropertyChanged("Item[PressDropResult]");
		}

		[ObservableProperty]
		public double? pressDropSpec;

		[IndexerName("Item")]
		public ValidationStatus this[string propertyName] {
			get {
				var errors = this.GetErrors().ToDictionary(k => k.MemberNames.First(), v => v.ErrorMessage) ?? new Dictionary<string, string?>();
				var hasErrors = errors.TryGetValue(propertyName, out var error);
				return new ValidationStatus(hasErrors, error ?? string.Empty);
			}
		}
	}


}