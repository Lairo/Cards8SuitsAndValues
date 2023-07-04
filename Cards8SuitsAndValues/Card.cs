namespace Cards8SuitsAndValues
{
    class Card
    {
        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
