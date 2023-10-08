namespace ClassLibrary_6
{
    public abstract class Car
    {
        public int Year { get; set; } = 2020;
        public int NumberOfSeats { get; set; }

        public virtual int GetNumberOfSeats()
        {
            return NumberOfSeats;
        }

        public int GetYear()
        {
            return Year;
        }

    }
}