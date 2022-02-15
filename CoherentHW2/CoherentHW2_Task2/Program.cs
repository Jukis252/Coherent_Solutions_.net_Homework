using HW2_Task2.Entities;

namespace HW2_Task2
{
    class Program
    {
        static void  Main()
        {
            var firstTraining = new Training("Internet security");
            var secondTraining = new Training("Back-End training");
            var thirdTraining = new Training("Front-End training");

            var firstLecture = new Lecture("C# basics", "variables");
            var secondLecture = new Lecture("C# basics", "Math in C#");
            var thirdLecture = new Lecture("SQL basics", "Creating tables");

            var firstPracticalLesson = new PracticalLesson("Create a class", "Make a simple class", "Class created");
            var secondPracticalLesson = new PracticalLesson("Create a calculator", "Make a simple calculator", "Calculator created");
            var thirdPracticalLesson = new PracticalLesson("Create a Database table", "Make a database table", "Database table created");

            void TestAddition()
            {
                firstTraining.Addition(firstLecture);
                secondTraining.Addition(secondLecture);
                thirdTraining.Addition(thirdLecture);

                Console.WriteLine(firstTraining);

                firstTraining.Addition(firstPracticalLesson);
                secondTraining.Addition(secondPracticalLesson);
                thirdTraining.Addition(thirdPracticalLesson);

                Console.WriteLine(firstTraining);
            }

            void TestIsPractical()
            {
                Console.WriteLine(firstTraining.IsPractical());
                Console.WriteLine(secondTraining.IsPractical());
                Console.WriteLine(thirdTraining.IsPractical());
            }

            void TestClone()
            {
                var fourTraining = firstTraining.Clone();
                fourTraining.Addition(thirdLecture);
                fourTraining.Addition(secondLecture);

                Console.WriteLine(firstTraining.ToString());
                Console.WriteLine("----------------------");
                Console.WriteLine(fourTraining.ToString());
                Console.WriteLine(firstTraining == fourTraining);
            }

            TestAddition();
            TestIsPractical();
            TestClone();

        }
    }
}