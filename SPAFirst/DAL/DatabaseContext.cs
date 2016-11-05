using SPAFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPAFirst.DAL
{
	public class DatabaseContext:DbContext
	{
		public DatabaseContext()
		{
			Database.SetInitializer(new CustomInitializer());
		}

		public DbSet<Person> People { get; set; }

	}
}