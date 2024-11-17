namespace leetcode.easy.Problems
{
    public class _67_Add_Binary
    {
        public static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            string result = "";

            while (i >= 0 || j >= 0 || carry == 1)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0'; // Convert char to int
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0'; // Convert char to int
                    j--;
                }

                result = (sum % 2) + result; // Add current bit to the result
                carry = sum / 2; // Calculate the new carry
            }

            return result;
        }

    }
}
