namespace MARCO.Medix.UI.Utils
{
    public class GenerateCode
    {

        public static string Code()
        {
            Random generator = new Random();
            string code = generator.Next(0, 100000000).ToString("D8");
            return code;
        }
    }
}
