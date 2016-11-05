using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPAFirst.DAL
{
	public class CustomInitializer:DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		static CustomInitializer()
		{
			
		}

		protected override void Seed(DatabaseContext context)
		{
			base.Seed(context);
		}
	}
}