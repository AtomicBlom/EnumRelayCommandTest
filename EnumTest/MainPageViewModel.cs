using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EnumTest
{
	public partial class MainPageViewModel : ObservableObject
	{
		[RelayCommand]
		private void OnSetSortOrder(SortOrder order)
		{
			Debug.WriteLine($"Sort order set to {order}");
			SortOrder = order;
		}

		private SortOrder _sortOrder;
		public SortOrder SortOrder
		{
			get => _sortOrder;
			set => SetProperty(ref _sortOrder, value);
		}

	}

	public enum SortOrder
	{
		Ascending,
		Descending
	}
}