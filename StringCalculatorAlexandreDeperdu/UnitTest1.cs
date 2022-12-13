namespace StringCalculatorAlexandreDeperdu
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\"" +
                            "QUAND on appelle Add" +
                            "ALORS on obtient x+y")]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void Test1(int x, int y)
        {
            //ETANT DONNE une chaine "x,y"
            var chaine = $"{x},{y}";
            //QUAND on appelle Add
            var résultat = StringCalculator.Add();

            //ALORS on obtient x + y
            Assert.Equal(x + y, résultat);

        }
    }
}
    