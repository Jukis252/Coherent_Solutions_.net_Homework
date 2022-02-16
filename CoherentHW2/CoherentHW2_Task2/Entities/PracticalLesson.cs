namespace HW2_Task2.Entities
{
    internal class PracticalLesson : Activities
    {
        private string Description { get; set; }
        private string TaskCondition { get; set; }
        public string TaskSolution { get; set; }


      public PracticalLesson(string description, string condition, string solution)
        {
            Description = description;
            TaskCondition = condition;
            TaskSolution = solution;
        }

        public override string ToString()
        {
            return $"Descripition: {Description}\n Task Condition: {TaskCondition}\n Task Solution: {TaskSolution}";
        }

        public override Activitys Clone()
        {
            return new PracticalLesson(this.Description, this.TaskCondition, this.TaskSolution);
        }
    }
}
