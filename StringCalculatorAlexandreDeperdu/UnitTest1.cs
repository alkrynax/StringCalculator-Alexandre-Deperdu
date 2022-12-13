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
            var r�sultat = StringCalculator.Add(chaine);

            //ALORS on obtient x + y
            Assert.Equal(x + y, r�sultat);

        }
        [Theory(DisplayName = "ETANT DONNE n nombres \"x,y,....\"" +
                            "QUAND on appelle Add" +
                            "ALORS on obtient la somme de n nombres")]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 8, 9, 6, 25)]
        public void TestNombres(params int[] x)
        {
            //ETANT DONNE n nombres "x,y,...."
            var entr�e = string.Join(',', x);
            //QUAND on appelle Add
            var r�sultat = StringCalculator.Add(entr�e);
            //ALORS on obtient la somme de n nombres
            Assert.Equal(x.Sum(), r�sultat);
        }
    }
}
    