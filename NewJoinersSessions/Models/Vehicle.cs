namespace NewJoinersSessions.Models
{
    /*
     *  Properties in Vehicle, Car, and Motorcycle classes are properly encapsulated with private fields and public getters and setters.
     */
    public abstract class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private int _odometer;

        protected Vehicle(string make, string model, int year, int odometer)
        {
            _make = make;
            _model = model;
            _year = year;
            _odometer = odometer;
        }
        public string Make
        {
            get => _make;
            set => _make = value;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public int Odometer
        {
            get => _odometer;
            set => _odometer = value;
        }

        public abstract string DisplayInfo();
    }

}
