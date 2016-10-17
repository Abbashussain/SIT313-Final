using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mainproject
{
	public partial class Order : ContentPage
	{
		
		public Order()
		{
			InitializeComponent();

		}

		public void save(Object sender, EventArgs a) {


			var todoItem = (MainItem)BindingContext;
			Savedatabase.Database.SaveItem(todoItem);
			this.Navigation.PopAsync();

		}
}	
	}
	


