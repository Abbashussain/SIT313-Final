using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace mainproject
{



	public class Books
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public decimal BookCost { get; set; }

	}
	public class Data
	{
		#region BooksList 
		public static ObservableCollection<Books> BooksList = new ObservableCollection<Books>
		{
			new Books {ID=1, Name="Health", BookCost=10.90m, },
			new Books {ID=2, Name="Sport", BookCost=11.99m},
			new Books {ID=3, Name="food", BookCost=9.90m},
			new Books {ID=4, Name="lifestyle", BookCost=14.50m},
			new Books {ID=5, Name="comic", BookCost=12.10m}

		};

		#endregion
	}
}

