using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univ_hostel.Models.RequestWork;

namespace univ_hostel.Models
{
	public class DefaultDbContext : DbContext
	{

		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Inhabitancy> Inhabitancies { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Speciality> Specialities { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<RequestResult> RequestStatuses { get; set; }

		public const string ContextName = "name=DefaultDatabase";

		private void Init()
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<DefaultDbContext, Migrations.Configuration>());
		}

		public DefaultDbContext(string nameOrConnectionString = ContextName) : base(nameOrConnectionString)
		{
			Init();
		}

		public DefaultDbContext() : base(ContextName)
		{
			Init();
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Entity<Faculty>().HasKey(f => f.Id);
			builder.Entity<Faculty>().Property(f => f.Name).IsRequired();
			builder.Entity<Group>().Property(g => g.EducationType).IsRequired();
			builder.Entity<Group>().Property(g => g.Name).IsRequired().HasMaxLength(255);
			builder.Entity<Group>().HasKey(g => g.Id).HasIndex(g => g.Name).IsUnique();
			builder.Entity<Group>().HasRequired(g => g.Speciality).WithMany();
			builder.Entity<Inhabitancy>().Property(i => i.Room).IsRequired();
			builder.Entity<Inhabitancy>().Property(i => i.Begin).IsRequired();
			builder.Entity<Inhabitancy>().HasKey(i => i.Id).HasRequired(i => i.Student).WithMany();
			builder.Entity<Payment>().HasKey(p => p.Id).HasRequired(p => p.Student).WithMany();
			builder.Entity<Payment>().Property(p => p.Cost).IsRequired();
			builder.Entity<Payment>().Property(p => p.Date).IsRequired();
			builder.Entity<Speciality>().HasKey(s => s.Id).HasRequired(s => s.Faculty).WithMany(f => f.Specialities);
			builder.Entity<Speciality>().Property(s => s.Name).IsRequired();
			builder.Entity<Speciality>().Property(s => s.Code).HasMaxLength(255).IsRequired();
			builder.Entity<Speciality>().HasIndex(s => s.Code).IsUnique();
			builder.Entity<Student>().Property(s => s.Address).IsRequired().HasMaxLength(1024);
			builder.Entity<Student>().Property(s => s.Birthday).IsRequired();
			builder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
			builder.Entity<Student>().Property(s => s.Lastname).IsRequired().HasMaxLength(50);
			builder.Entity<Student>().Property(s => s.Patronymic).IsRequired().HasMaxLength(50);
			builder.Entity<Student>().Property(s => s.PassportSeria).IsRequired().HasMaxLength(4);
			builder.Entity<Student>().Property(s => s.PassportNumber).IsRequired().HasMaxLength(6);
			builder.Entity<Student>().Property(s => s.TIN).IsRequired().HasMaxLength(12);
			builder.Entity<Student>().Property(s => s.PhoneNumber).HasMaxLength(20);
			builder.Entity<Student>().Property(s => s.Email).HasMaxLength(100);
			builder.Entity<Student>().HasKey(s => s.Id).HasIndex(s => new
			{
				s.Name,
				s.Lastname
			});
			builder.Entity<Student>().HasIndex(s => new
			{
				s.PassportNumber,
				s.PassportSeria
			}).IsUnique();
			builder.Entity<Student>()
				.HasRequired(s => s.Group)
				.WithMany(g => g.Students)
				.HasForeignKey(s => s.GroupId);
			builder.Entity<RequestResult>()
				.HasKey(r => r.Id)
				.HasRequired(r => r.Student)
				.WithMany()
				.HasForeignKey(r => r.StudentId);
			base.OnModelCreating(builder);
		}
	}
}
