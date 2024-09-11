namespace ConsoleTest1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            int score = 0;
            bool d = IsDigit(password);
            if (d) score += 1;
            bool l = IsLowercase(password);
            if (l) score += 1;
            bool u = IsUppercase(password);
            if (u) score += 1;
            bool spec = IsSpecialCharacter(password);
            if (spec) score += 1;
            bool lv = IsLengthValid(password);
            if (lv) score += 1;
            Console.WriteLine($"Пароль набрал: {score} из 5 баллов");
        }
        public static bool IsDigit(string password)
        {
            return password.Any(char.IsDigit);
        }
        public static bool IsLowercase(string password)
        {
            return password.Any(char.IsLower);
        }
        public static bool IsUppercase(string password)
        {
            return password.Any(char.IsUpper);
        }
        public static bool IsSpecialCharacter(string password)
        {
            return password.Any(char.IsPunctuation);
        }
        public static bool IsLengthValid(string password)
        {
            return password.Length > 7;
        }
    }
}
