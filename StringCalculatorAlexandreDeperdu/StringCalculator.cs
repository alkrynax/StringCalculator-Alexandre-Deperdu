using System.Threading.Channels;

namespace StringCalculatorAlexandreDeperdu
{
    internal class StringCalculator
    {
        public static object Add(string chaine)
        {
            var parties = chaine.Split(',');
            return parties.ElementAt(0)+parties.ElementAt(1);

        }
    }
}