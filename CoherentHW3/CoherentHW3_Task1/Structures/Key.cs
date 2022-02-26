namespace CoherentHW3_Task1.Structures
{

    enum Octave
    {
        SubContra,
        Contra,
        Great,
        Small,
        OneLine,
        TwoLine,
        ThreeLine,
        FourLine,
        FiveLine
    }

    enum Note
    {
        C,
        D,
        E,
        F,
        G,
        A,
        B
    }

    enum AlterationSign
    {
        NoSign,
        Sharp,
        Flat
    }
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
            int octaveComparisonResult = _octave.CompareTo(other._octave);

            if (octaveComparisonResult == 1)
            {
                return 1;
            }
            else if (octaveComparisonResult == -1)
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
            return $"Key: _note {_note} {_alterationSign} from {_octave} octave";
        }
    }
}
