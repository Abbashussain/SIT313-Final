using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mainproject
{
	public partial class Contact : ContentPage
	{
		public Contact()
		{
			InitializeComponent();
		}
		public void save(Object sender, EventArgs a)
		{

			string Feedback = Feed.Text;

			var mainItem = (MainItem)BindingContext;
			Savedatabase.Database.SaveItem(mainItem);
			this.Navigation.PopAsync();
		}
	}
}

