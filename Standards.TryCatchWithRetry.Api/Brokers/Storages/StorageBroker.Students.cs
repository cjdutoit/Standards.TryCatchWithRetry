using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Standards.TryCatchWithRetry.Api.Models.Students;

namespace Standards.TryCatchWithRetry.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }

        public async ValueTask<Student> InsertStudentAsync(Student student)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<Student> studentEntityEntry =
                await broker.Students.AddAsync(student);

            await broker.SaveChangesAsync();

            return studentEntityEntry.Entity;
        }

        public IQueryable<Student> SelectAllStudents()
        {
            using var broker =
                new StorageBroker(this.configuration);

            return broker.Students;
        }

        public async ValueTask<Student> SelectStudentByIdAsync(Guid studentId)
        {
            using var broker =
                new StorageBroker(this.configuration);

            return await broker.Students.FindAsync(studentId);
        }

        public async ValueTask<Student> UpdateStudentAsync(Student student)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<Student> studentEntityEntry =
                broker.Students.Update(student);

            await broker.SaveChangesAsync();

            return studentEntityEntry.Entity;
        }
    }
}
