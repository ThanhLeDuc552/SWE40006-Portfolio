namespace NumberTools
{
    public class NumberCounter
    {
        public int Value { get; private set; }

        public void Increment(int amount)
        {
            checked
            {
                Value += amount;
            }
        }

        public void Decrement(int amount)
        {
            checked
            {
                Value -= amount;
            }
        }

        public void Reset()
        {
            Value = 0;
        }
    }
}
