namespace CoherentHW3_Task1.Structures
{
    struct Key : IComparable<Key>
    {
        private readonly Octave _octave;
        private readonly Note _note;
        private readonly AlterationSign _alterationSign;

        public Key(Octave octave, Note note, AlterationSign alterationSign)
        {
            _octave = octave;
            _note = note;
            _alterationSign = alterationSign;
        }

        public int CompareTo(Key other)
        {
            int comparisonResult = _octave.CompareTo(other._octave);

            if (comparisonResult == 1)
            {
                return 1;
            }
            else if (comparisonResult == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Key) || obj == null)
            {
                return false;
            }
            else
            {
                return CompareTo((Key)obj) == 0;
            }
        }

        public override string ToString()
        {
            return $"Key: Note {_note} {_alterationSign} from {_octave} octave";
        }
    }
}
