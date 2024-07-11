namespace Assignment_10._2._2
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Justin", Age = 25, Salary = 6000 },
                new Employee { Name = "Jason", Age = 28, Salary = 5500 },
                new Employee { Name = "John", Age = 32, Salary = 4800 },
                
            };

            
            Console.WriteLine("Employees with salary > $5000 and age < 30:");
            foreach (var emp in employees)
            {
                if (emp.Salary > 5000 && emp.Age < 30)
                {
                    Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: ${emp.Salary}");
                }
            }
        }
    }
}
