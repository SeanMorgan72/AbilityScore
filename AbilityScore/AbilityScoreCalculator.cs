namespace AbilityScore
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            //Divide RollResult by the DivideBy field.
            double divided = RollResult / DivideBy;

            //Add AddAmount to the result of divided variable.
            int added = AddAmount + (int) divided;

            //If result is to small, use Minimum.
            if(added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
