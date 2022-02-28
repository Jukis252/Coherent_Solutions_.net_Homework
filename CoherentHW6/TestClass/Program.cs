using Attributes;

namespace TestClass
{
    public class Program
    {
        static void Main()
        {
            int number = 1;
            string firstName = "John";
            string lastName = "Black";
            int age = 25;
            string email = "gmail@mail.com";
            ClassToTest classTest = new (number,firstName,lastName,age,email);

            Logger logger = new("Output");

            logger.Track(classTest);
        }
    }
    
}

