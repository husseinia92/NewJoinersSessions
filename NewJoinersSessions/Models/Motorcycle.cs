namespace NewJoinersSessions.Models
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(string make, string model, int year, int odometer)
            : base(make, model, year, odometer)
        {
        }

        public override string DisplayInfo()
        {
            return $"Motorcycle: {Make}, {Model}, {Year}, {Odometer} miles";
        }
    }

}
