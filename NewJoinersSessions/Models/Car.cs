namespace NewJoinersSessions.Models
{
    public class Car : Vehicle
    {
        private int _numberOfDoors;

        public Car(string make, string model, int year, int odometer, int numberOfDoors)
            : base(make, model, year, odometer)
        {
            _numberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors
        {
            get => _numberOfDoors;
            set => _numberOfDoors = value;
        }

        public override string DisplayInfo()
        {
            return $"Car: {Make}, {Model}, {Year}, {Odometer} miles, {NumberOfDoors} doors";
        }
    }

}
