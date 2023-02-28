using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiValidation
{
	public partial class MainViewModel : ObservableValidator {
        public MainViewModel() {
			PartAResultLists = new ObservableCollection<PartAResultList>
			{
				new PartAResultList(){PressDropResult = 20, PressDropSpec = 10},
			};


		}
		[ObservableProperty]
		ObservableCollection<PartAResultList> partAResultLists;
	}
}
