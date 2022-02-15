using System.Text;

namespace HW2_Task2.Entities
{
    internal class Training
    {
        private string Description { get; set; }
        private Activitys[] ArrayOfTraining { get; set; }
        private int AddedTrainings { get; set; }

        private const int Size = 3;

        public Training(string description)
        {
            Description = description;
            ArrayOfTraining = new Activitys[Size];
            AddedTrainings = 0;
        }

        public void Addition(Activitys arrayOfTraining)
        {
            if (AddedTrainings < Size)
            {
                ArrayOfTraining[AddedTrainings] = arrayOfTraining;
                AddedTrainings++;

            }
            else
            {
                throw new IndexOutOfRangeException("Activities limit reached");
            }
        }

        public Training Clone()
        {
            var clone = new Training(this.Description);
            for (int i = 0; i < AddedTrainings; i++)
            {
                clone.ArrayOfTraining[i] = ArrayOfTraining[i].Clone();
            }

            return clone;
        }

        public bool IsPractical()
        {
            foreach (var training  in ArrayOfTraining)
            {
                if (training is Lecture)
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb;
            sb = new StringBuilder("Description: " + Description + "\n Training activity's: \n");
            foreach (var training in ArrayOfTraining)
            {
                sb.Append(training + "\n");
            }

            return sb.ToString();
        }
    }

}
