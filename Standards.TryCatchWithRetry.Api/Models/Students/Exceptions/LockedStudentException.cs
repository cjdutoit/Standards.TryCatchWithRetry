using System;
using Xeptions;

namespace Standards.TryCatchWithRetry.Api.Models.Students.Exceptions
{
    public class LockedStudentException : Xeption
    {
        public LockedStudentException(Exception innerException)
            : base(message: "Locked student record exception, please try again later", innerException)
        {
        }
    }
}