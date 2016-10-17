using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace mainproject
{
	public partial class mainprojectPage : ContentPage
	{
		async void Order(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new Order());
		}
		async void Contact(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new Contact());
		}
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new MyPage());
		}

		public mainprojectPage()
		{
			InitializeComponent();
		}
	}
}

