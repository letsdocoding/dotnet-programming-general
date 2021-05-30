using System.Threading;

namespace SwitchUpdates
{
    internal class SwitchUpdates
    {
        public string GetStudentRating(StudentResult studentResult)
        {
            //if (studentResult.Marks > 90)
            //{
            //    return "Very Good";
            //} else if (studentResult.Marks > 90 && /*studentResult.Marks < 90*/)
            //{
            //    return "Good";
            //}
            string rating = null;
            switch (studentResult.Marks)
            {
                // old school
                case 90:
                    rating = "Very Good";
                    break;
                case var marks when marks > 90:
                    rating = "Very Good";
                    break;
                case > 80:
                    rating = "Good";
                    break;
                default:
                    rating = "Failed";
                    break;
            }

            //switch expression
            rating = studentResult.Marks switch
            {
                90 => rating = "Very Good",
                > 90 => rating = "Very Good",
                >80 => rating = "Good",
                //Others
                _ => rating = "Failed"
            };

            //PropertyAccess
            rating = studentResult switch
            {
                {Marks:>95, StudentName: "Cheater"} => rating = "you are a cheater",
                {Marks:>90} => rating = "Very Good",
                // if studentResult is BonusResult 
                // Declarative approach
                BonusResult bonusResult => rating = $"Passed with bonus marks{bonusResult.BonusMarks}",
                //other conditions
                _ => rating = "Failed"
            };

            return rating;
        }


        public CompositeColor GetCompositeColor(Colors firstColor, Colors secondColor)
        {
            //tuple approach 
            CompositeColor color = (firstColor, secondColor) switch
            {
                (Colors.Red, Colors.Yellow) => CompositeColor.Orange,
                //same value gives error
                //(Colors.Red, Colors.Yellow) => CompositeColor.Orange,
                (Colors.Yellow, Colors.Red) => CompositeColor.Orange,
                (Colors.Blue, Colors.Red) => CompositeColor.Voilet,
                _ => CompositeColor.NOT_DEFINED
            };
            return color;
        }

    }

    internal enum Colors
    {
        Red,
        Blue,
        Yellow
    }

    internal enum CompositeColor
    {
        Voilet,
        Orange,
        NOT_DEFINED
    }


    public class StudentResult
    {
        public string StudentName { get; set; }
        public int Marks { get; set; }
    }

    public class BonusResult : StudentResult
    {
        public int BonusMarks { get; set; }
    }
}
