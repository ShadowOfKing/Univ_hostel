namespace univ_hostel.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using univ_hostel.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<univ_hostel.Models.DefaultDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(univ_hostel.Models.DefaultDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
			if (context.Faculties.Count() == 0)
			{
				var tree = new Dictionary<string, Dictionary<string, string[]>>
				{
					{ "‘¿œœ",
					new Dictionary<string, string[]>{
						{ "0",
						new string[]{
							"¡œŒ-15-01",
							"¡œŒÁ-15-01",
							"ÃœŒ-18-01"
						}
						}
					}
					},
					{ "‘““",
					new Dictionary<string, string[]>{
						{ "1",
						new string[]{
							"¡—“-16-01",
							"¡—“-17-01",
							"¡—“-18-01"
						}
						}
					}
					},
					{ "√Õ‘",
					new Dictionary<string, string[]>{
						{ "2",
						new string[]{
							"√√-18-01",
							"√‘-17-01",
							"¡√¡-15-01"
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
	}
}
