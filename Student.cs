
namespace StudentsDiary
{
   
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
        public string Math { get; set; }
        public string Technology { get; set; }
        public string Physics { get; set; }
        public string PolishLang { get; set; }
        public string EnglishLang { get; set; }
        public bool AdditionalClasses { get; set; }
    }

    public class Teacher : Person
    {      
        public string Position { get; set; }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - Nauczyciel.";
        }
    }

    public interface IPerson
    {
        string GetInfo();
    }

    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }

        public abstract string GetInfo();
    }
}