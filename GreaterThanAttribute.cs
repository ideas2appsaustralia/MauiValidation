using System.ComponentModel.DataAnnotations;

namespace MauiValidations
{
	public sealed class GreaterThanAttribute : ValidationAttribute
	{
		public GreaterThanAttribute(string propertyName)
		{
			PropertyName = propertyName;
		}

		public string PropertyName { get; }

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			object
				instance = validationContext.ObjectInstance,
				otherValue = instance.GetType().GetProperty(PropertyName).GetValue(instance);

			if (value is null) {
				return ValidationResult.Success;
			}

			if (((IComparable)value).CompareTo(otherValue) > 0)
			{
				return ValidationResult.Success;
			}

			return new("out of specification");
		}
	}
}
