int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split();
    string firstName = command[0];
    string lastName = command[1];
    double grade = double.Parse(command[2]);

    Student currentStudent = new Student (firstName, lastName, grade);
    students.Add(currentStudent);
}

students = students.OrderByDescending(s => s.Grade).ToList();

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}

