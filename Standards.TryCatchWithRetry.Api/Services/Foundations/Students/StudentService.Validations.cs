using Standards.TryCatchWithRetry.Api.Models.Students;
using Standards.TryCatchWithRetry.Api.Models.Students.Exceptions;

namespace Standards.TryCatchWithRetry.Api.Services.Foundations.Students
{
    public partial class StudentService
    {
        private void ValidateStudentOnAdd(Student student)
        {
            ValidateStudentIsNotNull(student);
        }

        private static void ValidateStudentIsNotNull(Student student)
        {
            if (student is null)
            {
                throw new NullStudentException();
            }
        }
    }
}