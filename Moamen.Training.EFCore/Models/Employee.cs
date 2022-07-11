namespace Moamen.Training.EFCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Car Car { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<FamilyMember> Kids { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

    public class FamilyMember
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

    public class Person
    {
        public int iD { get; set; }
        public string Name { get; set; }
        public ICollection<Cat> Cats { get; set; }
        public ICollection<Dog> Dogs { get; set; }
    }

    public class Cat
    {
        public int iD { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }

    public class Dog
    {
        public int iD { get; set; }
        public string Name { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
