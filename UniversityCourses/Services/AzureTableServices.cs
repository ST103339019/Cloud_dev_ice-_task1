using Azure.Data.Tables;
using UniversityCourses.Models;

namespace UniversityCourses.Services
{
    // This service connects the application to Azure Table Storage (Microsoft, 2026).
    public class AzureTableService
    {
        private readonly TableClient coursesTable;
        private readonly TableClient studentsTable;

        public AzureTableService(IConfiguration configuration)
        {
            // Gets the connection string from appsettings.json
            string connectionString = configuration.GetConnectionString("AzureStorage");

            // Connects to the Courses table
            coursesTable = new TableClient(connectionString, "Courses");

            // Connects to the Students table
            studentsTable = new TableClient(connectionString, "Students");

            // Creates the tables if they do not already exist
            coursesTable.CreateIfNotExists();
            studentsTable.CreateIfNotExists();
        }

        // Adds a new course to the Courses table
        public async Task AddCourse(Course course)
        {
            await coursesTable.AddEntityAsync(course);
        }

        // Gets all courses from the Courses table
        public async Task<List<Course>> GetCourses()
        {
            List<Course> courses = new List<Course>();

            await foreach (Course course in coursesTable.QueryAsync<Course>())
            {
                courses.Add(course);
            }

            return courses;
        }

        // This  Gets one course using its RowKey
        public async Task<Course?> GetCourse(string rowKey)
        {
            try
            {
                Course course = await coursesTable.GetEntityAsync<Course>(
                    "Course",
                    rowKey);

                return course;
            }
            catch
            {
                // If the course is not found, there is  return nothing
                return null;
            }
        }

        //  this Updates an existing course
        public async Task UpdateCourse(Course course)
        {
            await coursesTable.UpdateEntityAsync(
                course,
                course.ETag,
                TableUpdateMode.Replace);
        }

        // Deletes a course using its RowKey
        public async Task DeleteCourse(string rowKey)
        {
            await coursesTable.DeleteEntityAsync(
                "Course",
                rowKey);
        }
    }
}

// References
// Microsoft 2026, Azure.Data.Tables, Microsoft Learn [Online].
// Available at: https://learn.microsoft.com/en-us/dotnet/api/azure.data.tables.
// Accessed on 22 July 2026.