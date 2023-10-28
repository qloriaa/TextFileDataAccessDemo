using Bogus;
using System.IO;


namespace TextFileDataAccessDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get file path of original text file 
            string filePath = "..\\..\\..\\..\\TextDemo.txt";

            // Create a List of Persons
            List<Person> people = new List<Person>();
            // Create a List of lines read from original file
            List<String> lines = File.ReadAllLines(filePath).ToList();


            // Traverse lines List<> 
            foreach (string line in lines)
            {
                // Split each line at its delimiter ", "
                string[] entries = line.Split(", ");

                // Check that the string line was split to three properties in string[] entries (3 element array)
                if (entries.Length == 3)
                {
                    Person person = new Person();
                    person.firstName = entries[0];
                    person.lastName = entries[1];
                    person.Url = entries[2];
                    people.Add(person);
                }
                // Line does not have 3 properties (exactly 3 elements in array)
                else
                {
                    Console.WriteLine("This line has an incorrect number of columns: " + line);
                }
            }

            // Create a new List<> to generate new string lines 
            List<string> outputLines = new List<string>();

            // Traverse people List<> to create new string lines with each Person instance properties
            Console.WriteLine("Here is the list of people:");
            foreach (Person person in people)
            {
                // Print to console
                Console.WriteLine("First Name: " + person.firstName + "\tLast Name: " + person.lastName + "\tURL: " + person.Url);

                // Update the output list
                outputLines.Add("First Name: " + person.firstName + "\tLast Name: " + person.lastName + "\tURL: " + person.Url + "\n");

            }

            // Set designation for new text file and create/overwrite its content
            string outPath = Path.GetDirectoryName(filePath) + "\\PeopleOut.txt";
            File.WriteAllLines(outPath, outputLines);

            Console.ReadLine();
        }
    }
}