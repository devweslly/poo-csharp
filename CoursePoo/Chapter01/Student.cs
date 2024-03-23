using System.Globalization;

namespace Chapter01
{
    public class Student
    {
        public string Name;
        public double firstTri;
        public double secondTri;
        public double thirdTri;

        public void DisplaysNote()
        {
            double finalGrade = firstTri + secondTri + thirdTri;

            Console.WriteLine($"FINAL GRADE = {finalGrade.ToString("F2", CultureInfo.InvariantCulture)}");

            if (finalGrade > 60.00)
            {
                Console.WriteLine("PASSED");
            }
            else
            {
                Console.WriteLine("FAILED");
                Console.WriteLine($"{(60 - finalGrade).ToString("F2", CultureInfo.InvariantCulture)} POINTS WERE MISSING");
            }
        }
    }
}
