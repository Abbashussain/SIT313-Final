using System;
using SQLite;

namespace mainproject
{
	public class MainItem
	{
		public MainItem()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }
		public DateTime Date { get; set; }
	}
}