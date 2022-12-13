namespace StringCalculatorAlexandreDeperdu
{
    public class StringCalculator
    {
        public static object Add(string chaine)
        {
            var parties = chaine.Split(',');
            return parties.Select(int.Parse).Sum();
        }
    }
}