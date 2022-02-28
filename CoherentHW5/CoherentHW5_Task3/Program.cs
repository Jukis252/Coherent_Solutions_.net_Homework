using CoherentHW5_Task3.Entities;

namespace CoherentHW5_Task3
{
    class Program
    {
        static void Main()
        {
            var firstEmployee = new EmployeeVacations("John", new DateTime(2021, 1, 1), new DateTime(2021, 1, 30));
            var secondEmployee = new EmployeeVacations("Jeff", new DateTime(2021, 2, 1), new DateTime(2021, 6, 1));
            var thirdEmployee = new EmployeeVacations("Jim", new DateTime(2021, 3, 5), new DateTime(2021, 3, 6));
            var fourthEmployee = new EmployeeVacations("Janice", new DateTime(2021, 4, 11), new DateTime(2021, 4, 18));
            var fifthEmployee = new EmployeeVacations("Jerry", new DateTime(2021, 5, 29), new DateTime(2021, 6, 1));

            firstEmployee.IsEmployeeAStudent = true;
            secondEmployee.IsEmployeeAStudent = true;
            thirdEmployee.IsEmployeeAStudent = true;
            fourthEmployee.IsEmployeeAStudent = false;
            fifthEmployee.IsEmployeeAStudent = false;

            var managementVacation = new Management();

            managementVacation.AddVacation(firstEmployee);
            managementVacation.AddVacation(secondEmployee);
            managementVacation.AddVacation(thirdEmployee);
            managementVacation.AddVacation(fourthEmployee);
            managementVacation.AddVacation(fifthEmployee);

            double result = managementVacation.AverageVacationLengthOfOrganization();
            Console.WriteLine("Average vacation length in organization: " + result);


            foreach(var employee in managementVacation.AverageVacationLengthOfEmployees())
			{
				Console.WriteLine($"{employee.Item1}: {employee.Item2}");
			}

		    foreach(var month in managementVacation.MonthlyDistributionOfEmployeeVacation())
		    {
			    Console.WriteLine($"Month of the year(number): {month.Item1}, " +
			    $"Employee count that month(number): {month.Item2}");
		    }
            Console.WriteLine("Free vacation dates:");
			foreach(var day in managementVacation.DateNoEmployeeOnVacation())
			{
				Console.WriteLine(day.Date);
			}

            Console.WriteLine(managementVacation.VacationCrossingDates());
        }
    }
}

