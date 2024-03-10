namespace immutableID
{
    class Program
    {
        public record Student(string FirstName, string LastName)
        {

            // auto-implemented properties
            public int Id { get; init; }
            //public string FirstName { get; set; }
            //public string LastName { get; set; }
        }
        public static void Main()
        {

            // default constructor to enter ID
            Student student1 = new("Scooby", "Doo")
            {
                Id = 1
            };
            Console.WriteLine(student1);
            
            // parameterized constructor with blanks for names
            Student student = new("", "")
            {
                Id = 0
            };
            //Console.WriteLine(student);
            //don't need to print the blank student
            
            //parameterized constructor with student info- uses blank Id info
            Student student3 = new("Scrappy", "Doo");
            Console.WriteLine(student3);

        }
    }

}

        
    
