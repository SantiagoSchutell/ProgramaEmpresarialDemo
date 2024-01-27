namespace Coruse.Enitities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public  double ValuePerhour { get; set; }

        public int Hours { get; set; }


        public HourContract ()
        {
        
        }

        public HourContract(DateTime date, double valuePerhour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerhour;
            Hours = hours;
        }

        public double Totalvalue()
        {
            return Hours * ValuePerhour;
        }
    }
}
