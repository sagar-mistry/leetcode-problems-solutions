namespace leetcode.easy.Problems
{
    public class _69_sqrt
    {
        public static double MySqrt(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Square root of a negative number is not a real number.");
            }

            if (number == 0 || number == 1)
            {
                return number;
            }

            double start = 0, end = number, ans = 0;

            while (start <= end)
            {
                double mid = (start + end) / 2;

                if (mid * mid == number)
                {
                    return mid;
                }
                else if (mid * mid < number)
                {
                    start = mid + 0.0001;
                    ans = mid;
                }
                else
                {
                    end = mid - 0.0001;
                }
            }

            return Math.Round(ans, 5); // Rounded to 5 decimal places
        }
    }
}
