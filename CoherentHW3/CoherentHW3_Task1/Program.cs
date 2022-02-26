using System;
using CoherentHW3_Task1.Structures;

namespace PianoKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstKey = new Key(Octave.SubContra, Note.C, AlterationSign.NoSign);
            var secondKey = new Key(Octave.TwoLine, Note.E, AlterationSign.Sharp);
            var thirdKey = new Key(Octave.TwoLine, Note.E, AlterationSign.Flat);
            var forthKey = new Key(Octave.TwoLine, Note.E, AlterationSign.Flat);

            Console.WriteLine($"Compare {firstKey} to {secondKey}:");
            Console.WriteLine(firstKey.CompareTo(secondKey));
            Console.WriteLine(firstKey.Equals(secondKey));

            Console.WriteLine($"Compare {secondKey} to {thirdKey}:");
            Console.WriteLine(secondKey.CompareTo(thirdKey));
            Console.WriteLine(secondKey.Equals(thirdKey));

            Console.WriteLine($"Compare {thirdKey} to {forthKey}:");
            Console.WriteLine(thirdKey.CompareTo(forthKey));
            Console.WriteLine(thirdKey.Equals(forthKey));
        }
    }
}