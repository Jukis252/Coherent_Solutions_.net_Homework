using Attributes;

namespace TestClass
{
    [TrackingEntity]
    public class ClassToTest
    {
        [TrackingProperty(PropertyName = "Field")]
        public int Number;

        public ClassToTest(int number, string firstName, string lastName, int age, string email)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        [TrackingProperty]
        public string FirstName { get; set; }

        [TrackingProperty(PropertyName = "Name")]
        public string LastName { get; set; }

        [TrackingProperty]
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
