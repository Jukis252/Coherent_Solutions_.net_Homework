namespace HW2_Task2.Entities
{
    internal class PracticalLesson : Activitys
    {
        private string Description { get; set; }
        private string TaskCondition { get; set; }
        public string TaskSoliution { get; set; }


      public PracticalLesson(string description, string condition, string solution)
        {
            Description = description;
            TaskCondition = condition;
            TaskSoliution = solution;
        }

        public override string ToString()
        {
            return $"Descripition: {Description}\n Task Condition: {TaskCondition}\n Task Solution: {TaskSoliution}";
        }

        public override Activitys Clone()
        {
            return new PracticalLesson(this.Description, this.TaskCondition, this.TaskSoliution);
        }
    }
}
