using System.Threading.Channels;

namespace StringCalculatorAlexandreDeperdu
{
    internal class StringCalculator
    {

        public static object Add(string chaine)
        {
            
            var elementsAsString = chaine.Replace(Environment.NewLine, string.Empty)
                .Split(",");
            return String.Concat(elementsAsString);

        }
    }
}
