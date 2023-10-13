namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //bool result = IsPalindrome(num);
        }
        public static bool IsPalindrome(int x) 
        {
            char[] charArray = x.ToString().ToCharArray();
            char[] charReverse = charArray.Reverse().ToArray();

            bool result = charArray.SequenceEqual(charReverse);

            return result;
        }
    }
    
}