using Azure;
using Azure.Data.Tables;

namespace UniversityCourses.Models
{
    // This class stores student information in Azure Table Storage (Microsoft, 2026).

    public class Student : ITableEntity
    {
        // Groups all student records together
        public string PartitionKey { get; set; } = "Student";

        // Creates a unique ID for every student
        public string RowKey { get; set; } = Guid.NewGuid().ToString();

        public DateTimeOffset? Timestamp { get; set; }

        public ETag ETag { get; set; }

        // Student number assigned by the university
        public string StudentNumber { get; set; } = "";

        // Student's first name
        public string FirstName { get; set; } = "";

        // Student's last name
        public string LastName { get; set; } = "";

        // Student's email address
        public string Email { get; set; } = "";

        // Stores the course the student is enrolled in
        public string EnrolledCourse { get; set; } = "";
    }
}

// References
// Microsoft 2026, Azure.Data.Tables, Microsoft Learn,[Online] Available at :https://learn.microsoft.com/en-us/dotnet/api/azure.data.tables?view=azure-dotnet. Accessed 22 July 2026.