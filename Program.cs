using ExtentionMethods.ExtentionMethod;

namespace ExtentionMethods
{
    public static class IdentificationExtentions
    {
        public static bool HasId(this IIdentification identification)
        {
            return identification.Id > 0;
        }
    }
    public class Person : IIdentification
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        public int Id
        { get
            {
                return 7;
            }
        }
    }

    public interface IIdentification
    {
        public int Id { get; }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                var person = new Person("Ben", "Mark");
                Console.WriteLine($"{person.ToFullName()}");
                Console.WriteLine($"{person.HasId()}");
            }
        }
    }
