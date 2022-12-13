namespace StringCalculatorAlexandreDeperdu
{
    public class StringCalculator
    {
        public static object Add(string chaine)
        {
            var parties = chaine.Split(',');
            return int.Parse(parties[0])+ int.Parse(parties[1]);
        }
    }
}