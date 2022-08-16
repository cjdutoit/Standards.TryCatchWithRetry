using System.Threading.Tasks;
using Standards.TryCatchWithRetry.Api.Brokers.DateTimes;
using Standards.TryCatchWithRetry.Api.Brokers.Loggings;
using Standards.TryCatchWithRetry.Api.Brokers.Storages;
using Standards.TryCatchWithRetry.Api.Models.Students;

namespace Standards.TryCatchWithRetry.Api.Services.Foundations.Students
{
    public partial class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        private readonly IDateTimeBroker dateTimeBroker;
        private readonly ILoggingBroker loggingBroker;

        public StudentService(
            IStorageBroker storageBroker,
            IDateTimeBroker dateTimeBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.dateTimeBroker = dateTimeBroker;
            this.loggingBroker = loggingBroker;
        }

        public ValueTask<Student> AddStudentAsync(Student student) =>
            throw new System.NotImplementedException();
    }
}