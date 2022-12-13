using System.Threading.Channels;

namespace StringCalculatorAlexandreDeperdu
{
    internal class StringCalculator
    {
        public static object Add(string chaine)
        {
            var parties = chaine.Split(',');
            return String.Concat(parties);

        }
    }
}