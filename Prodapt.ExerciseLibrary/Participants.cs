namespace Prodapt.ExerciseLibrary
{
    public class Participants
    {
        public static string companyName;
        int empId;
        string name;
        double foundationMarks, webBasicMarks, dotnetMarks, totalMarks, obtainedMark, percentage;

        //Static Constructor
        static Participants()
        {
            companyName = "Corporate Unniversity";
        }

        public Participants() { }

        //Initialize all the parameters
        public Participants(int empId, string name, double foundationMarks, double webBasicMarks, double dotnetMarks)
        {
            this.empId = empId;
            this.name = name;
            this.foundationMarks = foundationMarks;
            this.webBasicMarks = webBasicMarks;
            this.dotnetMarks = dotnetMarks;
            this.totalMarks = 300;
        }

        //Calculate Obtained marks
        public void CalculateTotalObtainedMarks()
        {
            obtainedMark = foundationMarks + webBasicMarks + dotnetMarks;
        }

        public void CalculatePercentage()
        {
            percentage = obtainedMark / totalMarks * 100;
        }

        public string DisplayParticipants()
        {
            return $"Emp Id :{empId}\nName :{name}\nFoundation Mark :{foundationMarks}\nWeb Basic Mark :{webBasicMarks}\nDotnet mark:{dotnetMarks}" +
                $"\nObtained Mark :{obtainedMark}\nPercentage :{percentage}";
        }
    }
}
