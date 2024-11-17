using leetcode.easy.DataStructures;
using leetcode.easy.Problems;
using static leetcode.easy.Problems._21_Merge_Two_Nodelist;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("#########################################");
        Console.WriteLine("Problem-1");
        int[] nums = [2, 7, 11, 15];
        int target = 17;
        Console.WriteLine($"nums : {string.Join(",", nums)}");
        Console.WriteLine($"target : {target}");
        int[] result = _1_Two_Sum.TwoSum(nums, target);
        Console.WriteLine($"{result[0]},{result[1]}");
        Console.WriteLine("#########################################");
        Console.WriteLine("Problem-2");
        bool isPalindrom = _9_Is_Palindrome.IsPalindrome(-121);
        Console.WriteLine("#########################################");

        _13_Roman_to_Integer romanToInteger = new _13_Roman_to_Integer();
        int resultInteger1 = romanToInteger.RomanToInt("III");
        int resultInteger2 = romanToInteger.RomanToInt("LVIII");
        int resultInteger3 = romanToInteger.RomanToInt("MCMXCIV");

        Console.WriteLine("#########################################");

        _14_Longest_Common_Prefix longestCommonPrefex = new _14_Longest_Common_Prefix();
        string resultPrefix1 = longestCommonPrefex.LongestCommonPrefix(new string[] { "a" });
        string resultPrefix2 = longestCommonPrefex.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
        string resultPrefix3 = longestCommonPrefex.LongestCommonPrefix(new string[] { "dog", "racecar", "car" });
        string resultPrefix4 = longestCommonPrefex.LongestCommonPrefix(new string[] { "programming", "progress", "proactive", "pro" });

        Console.WriteLine("#########################################");
        _20_Valid_Paranthesis validParanthesis = new _20_Valid_Paranthesis();
        bool isValid1 = validParanthesis.IsValid("([])");
        bool isValid2 = validParanthesis.IsValid("()[]{}");
        bool isValid3 = validParanthesis.IsValid("(]");
        bool isValid4 = validParanthesis.IsValid("([])");

        Console.WriteLine("#########################################");
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        _21_Merge_Two_Nodelist mergeNodeObj = new _21_Merge_Two_Nodelist();
        ListNode mergedNode1 = mergeNodeObj.MergeTwoLists(list1, list2);

        list1 = null; list2 = null;
        ListNode mergedNode2 = mergeNodeObj.MergeTwoLists(list1, list2);

        list1 = null; list2 = new ListNode(0);
        ListNode mergedNode3 = mergeNodeObj.MergeTwoLists(list1, list2);

        Console.WriteLine("#########################################");
        int[] numsArray = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        _26_Remove_Duplicates_from_Sorted_Array sortArray = new _26_Remove_Duplicates_from_Sorted_Array();
        int k = sortArray.RemoveDuplicates(numsArray);

        Console.WriteLine("#########################################");
        _28_FindtheIndex_of_FirstOccurence obj28 = new _28_FindtheIndex_of_FirstOccurence();
        int index_1 = obj28.StrStr("sadbutsad", "sad");
        int index_2 = obj28.StrStr("leetcode", "leeto");

        Console.WriteLine("#########################################");

        _35_Search_Insert_Position obj29 = new _35_Search_Insert_Position();
        int[] nums1 = [1, 3, 5, 6];
        int target1 = 5;
        int[] nums2 = [1, 3, 5, 6];
        int target2 = 2;
        int[] nums3 = [1, 3, 5, 6];
        int target3 = 7;

        //int index_35_1 = obj29.SearchInsert(nums1, target1);
        int index_35_2 = obj29.SearchInsert(nums2, target2);
        int index_35_3 = obj29.SearchInsert(nums3, target3);

        Console.WriteLine("#########################################");
        _58_Length_of_Last_Word obj58 = new _58_Length_of_Last_Word();
        string s1 = "Hello World";
        string s2 = "   fly me   to   the moon  ";
        string s3 = "luffy is still joyboy";
        int length_58_1 = obj58.LengthOfLastWord(s1);
        int length_58_2 = obj58.LengthOfLastWord(s2);
        int length_58_3 = obj58.LengthOfLastWord(s3);

        Console.WriteLine("#########################################");

        _66_Plus_One obj66 = new _66_Plus_One();
        int[] digits1 = [1, 2, 3];
        int[] digits2 = [4, 3, 2, 1];
        int[] digits3 = [9];
        int[] digits4 = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];

        int[] result66_1 = obj66.PlusOne(digits1);
        int[] result66_2 = obj66.PlusOne(digits2);
        int[] result66_3 = obj66.PlusOne(digits3);
        int[] result66_4 = obj66.PlusOne(digits4);

        Console.WriteLine("#########################################");

        var resultArray = DataStructure.PlayWithArray();
        var resultList = DataStructure.PlayWithList();
        var resultHashset = DataStructure.PlayWithHashset();
        var resultLinkedList = DataStructure.PlayWithLinkedList();

        Console.WriteLine("#########################################");
        Console.WriteLine("Example 1:");
        string a1 = "11";
        string b1 = "1";
        Console.WriteLine($"Input: a = \"{a1}\", b = \"{b1}\"");
        Console.WriteLine($"Output: {_67_Add_Binary.AddBinary(a1, b1)}");

        Console.WriteLine("Example 2:");
        string a2 = "1010";
        string b2 = "1011";
        Console.WriteLine($"Input: a = \"{a2}\", b = \"{b2}\"");
        Console.WriteLine($"Output: {_67_Add_Binary.AddBinary(a2, b2)}");

        Console.WriteLine("#########################################");
        var a = _69_sqrt.MySqrt(4);
        var b = _69_sqrt.MySqrt(8);
    }
}
