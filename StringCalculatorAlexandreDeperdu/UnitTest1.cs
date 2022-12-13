using System.Linq;
using Xunit.Sdk;

namespace StringCalculatorAlexandreDeperdu
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\"" +
                            "QUAND on appelle Add" +
                            "ALORS on obtient x+y")]
        [InlineData(1, 2)]
        [InlineData(0, 0)]
        public void TestAjouter(int x, int y)
        {
            //ETANT DONNE une chaine "x,y"
            var chaine = $"{x},{y}";
            //QUAND on appelle Add
            var résultat = StringCalculator.Add(chaine);

            //ALORS on obtient x + y
            Assert.Equal(x.ToString() + y.ToString(), résultat);

        }
        [Theory(DisplayName = "ETANT DONNE n nombres \"x,y,....\"" +
                            "QUAND on appelle Add" +
                            "ALORS on obtient la somme de n nombres")]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 8, 9, 6, 25)]
        [InlineData(2, 8, 9, 19)]
        public void TestNombres(params int[] x)
        {
            //ETANT DONNE n nombres "x,y,...."
            var entrée = string.Join(',', x);
            //QUAND on appelle Add
            var résultat = StringCalculator.Add(entrée);
            //ALORS on obtient la somme de n nombres
            Assert.Equal(String.Concat(x), résultat);
        }
        [Fact(DisplayName= "ETANT DONNE une chaîne \"x, y\" ayant un saut de ligne en cours de nombre"+
                           "QUAND on l'envoie à Add"+
                           "// ALORS on obtient un entier x+y")]
        public void TestSautsLigne()
        {
            // ETANT DONNE une chaîne "x, y" ayant un saut de ligne en cours de nombre
            var chaîne = "1,1" + Environment.NewLine + "0";

            // QUAND on l'envoie à Add
            var résultat = StringCalculator.Add(chaîne);

            // ALORS on obtient un entier x+y
            Assert.Equal("110", résultat);
        }



    }
}