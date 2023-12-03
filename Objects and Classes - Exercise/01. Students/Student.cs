
    internal class Student
    {
        private string firstName;
        private string lastName;
        private double grade;

        public Student(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }

        }

        public double Grade 
        {
            get { return this.grade; }
            set { this.grade = value; }

        }
    }

