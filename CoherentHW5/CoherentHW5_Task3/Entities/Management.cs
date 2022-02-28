namespace CoherentHW5_Task3.Entities;

internal class Management
{
    private readonly List<EmployeeVacations> _employeeVacations;

    public Management()
    {
        _employeeVacations = new List<EmployeeVacations>();
    }

    public void AddVacation(EmployeeVacations vacation)
    {
        if (vacation.IsEmployeeAStudent)
            _employeeVacations.Add(vacation);
        else if (!_employeeVacations.Any(
                     vacationRecord => vacationRecord.NameOfEmployee.Equals(vacation.NameOfEmployee)))
            _employeeVacations.Add(vacation);
        else
            throw new Exception("Vacation limit reached.");
    }

    public bool VacationCrossingDates()
    {
        return _employeeVacations
            .Any(item => _employeeVacations
                .Where(otherItem => otherItem != item)
                .Any(otherItem => otherItem.NameOfEmployee.Equals(item.NameOfEmployee)
                                  && otherItem.LastVacationDay >= item.FirstVacationDay
                                  && otherItem.FirstVacationDay <= item.LastVacationDay));
    }

    public IEnumerable<(string, double)> AverageVacationLengthOfEmployees()
    {
        var employeeVacationAverage = _employeeVacations.GroupBy(employee => employee.NameOfEmployee,
                employeeVacation => employeeVacation.EmployeesAllVacationTime())
            .Select(employeeVacationAvg => (employeeVacationAvg.Key, employeeVacationAvg.Average()));

        foreach (var employee in employeeVacationAverage) yield return (employee.Key, employee.Item2);
    }

    public double AverageVacationLengthOfOrganization()
    {
        return _employeeVacations.Average(employee => employee.EmployeesAllVacationTime());
    }

    public IEnumerable<DateTime> DateNoEmployeeOnVacation()
    {
        var startOfYearDate = new DateTime(2021, 01, 01);
        var endOfYearDate = new DateTime(2021, 12, 31);

        var allDatesOfYear = Enumerable.Range(0, endOfYearDate.Subtract(startOfYearDate).Days + 1)
            .Select(day => startOfYearDate.AddDays(day));

        return allDatesOfYear.Except(
            _employeeVacations.SelectMany(employee => employee.GetAllVacationDatesOfEmployee()));
    }

    public IEnumerable<(int, int)> MonthlyDistributionOfEmployeeVacation()
    {
        foreach (var month in Enumerable.Range(1, 12).ToList())
            yield return (month, _employeeVacations.Count(vacation => vacation.FirstVacationDay.Month <= month
                                                                      && vacation.LastVacationDay.Month >= month));
    }
}