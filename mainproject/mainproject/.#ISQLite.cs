using System;
using SQLite;

namespace mainproject
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection(); //this is the database helper.... it helps to iomport sql connection
	}
}