namespace String1
{
    public class Program
    {
        public static void Main()
        {
            //String_unit.Method();
            var text = "This is going to be a really really really long";
            var summary = SummaryText.Method(text, 22);
            //Console.WriteLine(summary);
            BuilderString.Method();
        }
    }
}
