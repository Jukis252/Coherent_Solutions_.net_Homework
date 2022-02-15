namespace HW2_Task2.Entities
{
    internal class Lecture : Activitys
    {
        private string Description { get; set; }
        private string Topic { get; set; }

        public Lecture(string description, string topic)
        {
            Description = description;
            Topic = topic;
        }

        public override string ToString()
        {
            return $"Description: {Description}, topic: {Topic}";
        }

        public override Activitys Clone()
        {
            return new Lecture(this.Description, this.Topic);
        }
    }
}
