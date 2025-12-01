using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet cho mọi bảng
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<CourseClass> CourseClasses { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<RegradeRequest> RegradeRequests { get; set; }

        public DbSet<TuitionFee> TuitionFees { get; set; }
        public DbSet<TuitionPayment> TuitionPayments { get; set; }

        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationReceiver> NotificationReceivers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.StudentClass)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Major)
                .WithMany(m => m.Students)
                .HasForeignKey(s => s.MajorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseClass>()
                .HasOne(c => c.Schedule)
                .WithOne(s => s.CourseClass)
                .HasForeignKey<Schedule>(s => s.CourseClassId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);

            
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added);
            foreach (var entityEntry in entries)
            {
                var prop = entityEntry.Property("CreatedAt");
                if (prop != null && (prop.CurrentValue == null || (DateTime)prop.CurrentValue == default))
                {
                    prop.CurrentValue = DateTime.UtcNow;
                }
                var updatedAtProp = entityEntry.Property("UpdatedAt");
                if (updatedAtProp != null && (updatedAtProp.CurrentValue == null || (DateTime)updatedAtProp.CurrentValue == default))
                {
                    updatedAtProp.CurrentValue = null;
                }
            }
            var entriesModified = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified);

            foreach (var entityEntry in entriesModified)
            {
                var createdAtProp = entityEntry.Property("CreatedAt");
                if (createdAtProp != null)
                {
                    createdAtProp.IsModified = false;  
                }
                var updatedAtProp = entityEntry.Property("UpdatedAt");
                if (updatedAtProp != null)
                {
                    updatedAtProp.CurrentValue = DateTime.UtcNow;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }

}
