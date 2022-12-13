using System.Threading.Channels;

namespace StringCalculatorAlexandreDeperdu
{
    internal class StringCalculator
    {

        public static object Add(string chaine)
        {
            var délimitateur = ",";
            var elementsAsString = chaine.Replace(Environment.NewLine, string.Empty)
                .Split(délimitateur);
            return String.Concat(elementsAsString);

        }
    }
}