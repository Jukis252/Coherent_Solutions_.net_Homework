namespace CoherentHW5_Task3.Entities
{
    internal record EmployeeVacations
    {
        public EmployeeVacations(string nameOfEmployee, DateTime firstVacationDay, DateTime lastVacationDay)
        {
            if (firstVacationDay.Year == 2021 && lastVacationDay.Year == 2021 && firstVacationDay <= lastVacationDay)
            {
                this.NameOfEmployee = nameOfEmployee;
                FirstVacationDay = firstVacationDay;
                LastVacationDay = lastVacationDay;
            }
            else
            {
                throw new ArgumentException($"This adds only records of 2021 year");
            }
        }
        public string NameOfEmployee { get; }
        public DateTime FirstVacationDay { get; }
        public DateTime LastVacationDay { get; }
        public bool IsEmployeeAStudent { get; set; }

        public double EmployeesAllVacationTime()
        {
            return (LastVacationDay - FirstVacationDay).Days + 1;
        }

        public IEnumerable<DateTime> GetAllVacationDatesOfEmployee()
        {
            return Enumerable.Range(0, LastVacationDay.Subtract(FirstVacationDay).Days + 1)
                .Select(day => FirstVacationDay.AddDays(day));
        }
    }
}
