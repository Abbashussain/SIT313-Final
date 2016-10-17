using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace mainproject
{
	public class Database
	{
		static object locker = new object();

		SQLiteConnection database; //creating a connection for database

		public Database()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();
			// create the tables
			database.CreateTable<MainItem>();
		}

		public IEnumerable<MainItem> GetItems()
		{
			lock (locker)
			{

				return (from i in database.Table<MainItem>() select i).ToList();
			}
		}

		public IEnumerable<MainItem> GetItemsNotDone()
		{
			lock (locker)
			{
				return database.Query<MainItem>("SELECT * FROM [MainItem] WHERE [Done] = 0");
			}
		}
		//This will get the items from database
		public MainItem GetItem(int id)
		{
			lock (locker)
			{
				return database.Table<MainItem>().FirstOrDefault(x => x.ID == id);
			}
		}
		//function to save the information on database
		public int SaveItem(MainItem item)
		{
			lock (locker)
			{
				if (item.ID != 0)
				{
					database.Update(item);
					return item.ID;
				}
				else {
					var newbook = new MainItem   // creating a variable to create database entities 
						
					{
						ID = item.ID,
						Name = item.Name,
						Notes = item.Notes,
						Done = item.Done,
						Date = DateTime.UtcNow,

					};
					return database.Insert(newbook);
				}
			}
		}

		//function to delete the information on database
		public int DeleteItem(int id)
		{
			lock (locker)
			{
				return database.Delete<MainItem>(id);
			}
		}
	}
}

