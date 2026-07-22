using Azure;
using Azure.Data.Tables;

namespace UniversityCourses.Models
{
    
    // This class represents one course stored in Azure Table Storage (Microsoft, 2026).

    public class Course : ITableEntity
    {
        // Groups all course records together
        public string PartitionKey { get; set; } = "Course";

        // Creates a unique ID for every course
        public string RowKey { get; set; } = Guid.NewGuid().ToString();

        // Automatically updated by Azure
        public DateTimeOffset? Timestamp { get; set; }

        // Used by Azure for updates
        public ETag ETag { get; set; }

        // Course details
        public string CourseCode { get; set; } = "";

        public string CourseName { get; set; } = "";

        public string Lecturer { get; set; } = "";
    }
}
//Microsoft.2026. Azure.Data.Tables. [Online] https://learn.microsoft.com/en-us/dotnet/api/azure.data.tables?view=azure-dotnet.Accessed 22 July 2026.