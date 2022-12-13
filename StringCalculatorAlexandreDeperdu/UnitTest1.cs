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



    }
}