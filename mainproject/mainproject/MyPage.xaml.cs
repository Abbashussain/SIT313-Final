using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace mainproject
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();

			ListView.ItemsSource = Data.BooksList;
		}
	}

}

