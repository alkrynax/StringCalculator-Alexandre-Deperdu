namespace StringCalculatorAlexandreDeperdu
{
    public class UnitTest1
    {
        [Fact(DisplayName = "ETANT DONNE une chaine \"1,1\"" +
                            "QUAND on appelle Add" +
                            "ALORS on obtient 1+1=11")]
        public void Test1()
        {
            //ETANT DONNE une chaine "1,1"
            var chaine = "1,1";
            //QUAND on appelle Add
            var r�sultat = StringCalculator.Add();

            //ALORS on obtient 2
            Assert.Equal(1 + 1, r�sultat);

        }
       

     
    }
}