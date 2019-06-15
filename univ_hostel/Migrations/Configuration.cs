namespace univ_hostel.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using univ_hostel.Models;

	public class MigrateDBConfiguration : DbMigrationsConfiguration<DefaultDbContext>
	{
		protected override void Seed(DefaultDbContext context)
		{
			base.Seed(context);
			Configuration._Seed(context);
		}
	}

	internal sealed class Configuration : DbMigrationsConfiguration<univ_hostel.Models.DefaultDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			var inilializer = new MigrateDatabaseToLatestVersion<DefaultDbContext, MigrateDBConfiguration>();
			Database.SetInitializer(inilializer);
		}

		public static void _Seed(DefaultDbContext context)
		{
			if (context.Faculties.Count() == 0)
			{
				var tree = new Dictionary<string, Dictionary<string, string[]>>
				{
					{ "ФАПП",
					new Dictionary<string, string[]>{
						{ "0",
						new string[]{
							"БПО-15-01",
							"БПОЗ-15-01",
							"БПО-18-01"
						}
						}
					}
					},
					{ "ГНФ",
					new Dictionary<string, string[]>{
						{ "1",
						new string[]{
							"БГБ-16-01",
							"БГБ-17-01",
							"БГБ-18-01"
						}
						}
					}
					},
					{ "ФОНД",
					new Dictionary<string, string[]>{
						{ "2",
						new string[]{
							"БКП-18-01",
							"БНИ-18-01",
							"МДУ-17-01"
						}
						}
					}
					}
				};
				foreach (var tf in tree)
				{
					var faculty = new Faculty { Name = tf.Key };
					context.Faculties.Add(faculty);
					foreach (var ts in tf.Value)
					{
						var speciality = new Speciality { Name = ts.Key, Code = ts.Key, Faculty = faculty };
						context.Specialities.Add(speciality);
						foreach (var tg in ts.Value)
						{
							var group = new Group { Name = tg, Speciality = speciality, EducationType = EducationType.Fulltime };
							context.Groups.Add(group);
						}
					}
				}
				context.SaveChanges();
			}
		}

		protected override void Seed(DefaultDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
			_Seed(context);
		}
	}
}
