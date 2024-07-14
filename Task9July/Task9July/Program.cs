namespace Task9July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balinizi daxil edin:");
            int num = Convert.ToInt32 (Console.ReadLine());
            //Task.IfElse(num);
            Console.WriteLine(Task.SwitchCase(num));
        }
    }
    public class Task 
    {
        public readonly int Value;
         
        public static string IfElse(int num) 
        {
            string result =string.Empty;
            if (num < 50 && num > 0)
            {
                result = "F";
                return result;
            }
            else if (num < 60) { result = "E";return result; }
            else if (num < 70) { result = "D";return result; }
            else if (num < 80) { result = "C";return result; }
            else if (num < 90) { result = "B";return result; }
            else if (num < 100) { result = "A";return result; }
            else { result = "Dogru Bal daxil edilmeyib";return result; }
        }
        public static string SwitchCase(int num) 
        {
            string result = string.Empty;
            switch (num)
            {
                case  >= 50  and < 60:
                    result = "E";
                    return result;
                case >= 60 and < 70:
                    result = "E";
                    return result;
                case >= 70  and < 80:
                    result = "E";
                    return result;
                default: return result;
            }
        }
    }
}
