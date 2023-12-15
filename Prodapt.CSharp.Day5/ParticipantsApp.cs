using System;
using Prodapt.ExerciseLibrary;

namespace Prodapt.CSharp.Day5
{
    internal class ParticipantsApp
    {
        static void Main(string[] args)
        {
            Participants obj = new Participants(1001, "Kavin", 99.5, 98.6, 97.6);
            obj.CalculateTotalObtainedMarks();
            obj.CalculatePercentage();
            Console.WriteLine($"----------- {Participants.companyName}------------");
            var result = obj.DisplayParticipants();
            Console.WriteLine(result);
        }
    }
}
