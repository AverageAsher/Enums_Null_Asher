using System;
using System.IO;

namespace Enums_Null_Asher
{
    // Global enum for Months
    public enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Set birth month, day, and year
            int myBirthMonth = (int)Months.Jun; // Replace with your birth month
            int myBirthDay = 7; // Replace with your birth day
            int myBirthYear = 2005; // Replace with your birth year

            // Create birth date string
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

            // Create and write to a file
            string fileName = "myFile.txt";
            string initialText = "This is the initial text in the file.";
            File.WriteAllText(fileName, initialText + Environment.NewLine);

            // Read and display the file content
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine("Content of myFile.txt:");
            Console.WriteLine(fileContent);

            // Append text to the file
            string appendText = "This is the appended text.";
            File.AppendAllText(fileName, appendText + Environment.NewLine);

            // Read and display the file content after appending
            fileContent = File.ReadAllText(fileName);
            Console.WriteLine("Content of myFile.txt after appending:");
            Console.WriteLine(fileContent);

            // Copy the file to a new file
            string newFileName = "newFile.txt";
            File.Copy(fileName, newFileName, true);

            // Append the birth date string to the new file
            File.AppendAllText(newFileName, myBirthDate + Environment.NewLine);

            // Read and display the content of the new file
            string newFileContent = File.ReadAllText(newFileName);
            Console.WriteLine("Content of newFile.txt:");
            Console.WriteLine(newFileContent);
        }
    }
}