using System;
using System.Linq;
using System.Threading.Tasks;
using Standards.TryCatchWithRetry.Api.Models.Students;

namespace Standards.TryCatchWithRetry.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Student> InsertStudentAsync(Student student);
        IQueryable<Student> SelectAllStudents();
        ValueTask<Student> SelectStudentByIdAsync(Guid studentId);
        ValueTask<Student> UpdateStudentAsync(Student student);
    }
}
