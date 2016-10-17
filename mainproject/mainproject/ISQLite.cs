using System;
using SQLite;

namespace mainproject
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}