using System;
using SQLite;

namespace mainproject
{
	public class MainItem
	{
		public MainItem()
		{
		}
		// these are the entites of the databse with the the primary keys 
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
		public DateTime Date { get; set; }
	}
}