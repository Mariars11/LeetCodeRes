namespace Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("III");
        }
        public static int RomanToInt(string s) {
            Dictionary<char, int> dictValues = new();
            int romanAsInt = 0;

            dictValues.Add('I', 1);
            dictValues.Add('V', 5);
            dictValues.Add('X', 10);
            dictValues.Add('L', 50);
            dictValues.Add('C', 100);
            dictValues.Add('D', 500);
            dictValues.Add('M', 1000);
            
            s = s.Replace("IV","IIII");
            s = s.Replace("IX","VIIII");
            s = s.Replace("XL","XXXX");
            s = s.Replace("XC","LXXXX");
            s = s.Replace("CD","CCCC");
            s = s.Replace("CM","DCCCC");

            foreach(var c in s){
                romanAsInt += dictValues[c];
            }


            return romanAsInt;
        }
    }
    
}