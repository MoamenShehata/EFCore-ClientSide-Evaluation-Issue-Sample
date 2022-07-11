namespace Moamen.Training.EFCore
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
    }
}
