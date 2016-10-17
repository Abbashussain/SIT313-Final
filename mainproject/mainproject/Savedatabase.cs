using System;
using Xamarin.Forms;
using System.Diagnostics;
using SQLite;
using System.Collections.ObjectModel;

namespace mainproject
{
	public class Savedatabase : Application
	{
		static Database database;





		public Savedatabase()
		{
			
		}

		public static explicit operator Page(Savedatabase v)
		{
			throw new NotImplementedException();
		}

		public static Database Database
		{
			get
			{
				if (database == null)
				{
					database = new Database();
				}
				return database;
			}
		}

		public int ResumeAtSaveId { get; set; }


	}
}


