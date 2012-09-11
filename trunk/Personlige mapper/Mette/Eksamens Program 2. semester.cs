using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B130B
{
    class Program
    {
        //Class containing dimensions
        public class Dimensions
        {
            double Height;
            double Width;
            double Depth;
            
            //Constructor for Dimensions
            public Dimensions(double x, double y, double z)
            {
                Height = x;
                Width = y;
                Depth = z;
            }

            //Method to print dimensions
            public string Print()
            {
                return "Height: " + Height + ", Width: " + Width + ", Depth: " + Depth;
            }
        }

        //Vehicle class
        public abstract class Vehicle
        {
            //Initialize variables
            private string _Model, _Brand;
            private int _Year, _Price;
            private double _Km;
            protected char _EClass;
            protected int _TopSpeed, _Fuel;
            protected double _Engine, _KmPrL;
            protected string _DriverLicense;
            protected string[] FuelName = { "Diesel", "Octan92", "Octan95" };
            protected Dealer _CarDealer;

            public string Brand
            {
                get { return _Brand; }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        _Brand = value;
                    }
                }
            }

            public string Model
            {
                get { return _Model; }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        _Model = value;
                    }
                }
            }

            public double Km
            {
                get { return _Km; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        _Km = value;
                    }
                }
            }

            public virtual int Year
            {
                get { return _Year; }

                //Year can only be set when vehicle is instansiated
                protected set
                {
                    //If year is out of range, set it to min/max value
                    if (value <= 1950)
                    {
                        _Year = 1950;
                    }
                    else if (value >= DateTime.Now.Year)
                    {
                        _Year = DateTime.Now.Year;
                    }
                    else
                    {
                        _Year = value;
                    }
                }
            }

            public string Fuel
            {
                get { return FuelName[_Fuel]; }
                /*private set
                {
                    if (value > 0 && value < 4)
                    {
                        _Fuel = value;
                    }
                }*/
            }

            public virtual double KmPrL
            {
                get { return _KmPrL; }
                set
                {
                    _KmPrL = value;


                    //Set energy class based on KmPrL and Fuel type
                    if (_Fuel == 1)
                    {
                        if (_KmPrL > 25)
                        {
                            _EClass = 'A';
                        }
                        else if (_KmPrL > 20 && _KmPrL <= 25)
                        {
                            _EClass = 'B';
                        }
                        else if (_KmPrL > 15 && _KmPrL <= 20)
                        {
                            _EClass = 'C';
                        }
                        else
                        {
                            _EClass = 'D';
                        }
                    }
                    else
                    {
                        if (_KmPrL > 20)
                        {
                            _EClass = 'A';
                        }
                        else if (_KmPrL > 15 && _KmPrL <= 20)
                        {
                            _EClass = 'B';
                        }
                        else if (_KmPrL > 10 && _KmPrL <= 15)
                        {
                            _EClass = 'C';
                        }
                        else
                        {
                            _EClass = 'D';
                        }
                    }
                }
            }

            public char EClass
            {
                get { return _EClass; }
            }

            public int Price
            {
                get { return _Price; }
                set { _Price = value; }
            }

            public abstract int TopSpeed { get; set; }
            public abstract double Engine { get; set; }

            public virtual string Title
            {
                get { return Brand + " " + _Model + " " + _Engine; }
            }

            public Dealer CarDealer
            {
                get { return _CarDealer; }
                set { _CarDealer = value; }
            }

            public virtual string DriverLicense
            {
                get { return _DriverLicense; }
                set { }
            }


            //Constructor for the vehicle class
            public Vehicle(string brand, string model, int km, int year, int price,
                           double engine, double kmprl, int fuel, Dealer cardealer)
            {
                this.Brand = brand;
                this.Model = model;
                this.Km = km;
                this.Year = year;
                this.Price = price;
                this.Engine = engine;
                this.KmPrL = kmprl;
                this._Fuel = fuel;
                this.CarDealer = cardealer;
            }


            public Vehicle(string brand, string model, int year, int fuel, Dealer cardealer)
            {
                this.Brand = brand;
                this.Model = model;
                this.Year = year;
                this._Fuel = fuel;
                this.CarDealer = cardealer;
            }

            //Override of ToString method
            public override string ToString()
            {
                return ("Brand: " + Brand + "\n Model: " + Model + "\n Km: " + Km + "\n Year: " + Year + "\n Price: " + Price + "\n Topspeed: " + TopSpeed + "\n Engine: " + Engine + "\n Kmprl: " + KmPrL + "\n Fuel: " + Fuel + "\n Eclass: " + EClass + "\n Title: " + Title + "\n Cardealer: " + CarDealer.Name);
            }
        }
        
        //Car subclass of Vehicle
        public class Car : Vehicle
        {
            //Has extra information: Veteran
            private bool _Veteran = false;

            public override int Year
            {
                get
                {
                    return base.Year;
                }
                protected set
                {
                    base.Year = value;

                    //If the car is old enough, it is a veteran car
                    if ((DateTime.Now.Year - value) >= 25)
                    {
                        _Veteran = true;
                    }
                }
            }

            public bool Veteran
            {
                get { return _Veteran; }
            }

            public override string Title
            {
                get
                {
                    //If the car is veteran, the info is added to the title
                    if (Veteran == true)
                    {
                        return Brand + " " + Model + " " + Engine + " " + "Veteran";
                    }
                    else
                    {
                        return Brand + " " + Model + " " + Engine;
                    }
                }
            }

            public override int TopSpeed
            {
                get { return _TopSpeed; }
                set
                {
                    //A car has topspeed 407
                    _TopSpeed = 407;
                }
            }

            public override double Engine
            {
                get { return _Engine; }
                set
                {
                    //A car has engine size between 1.0 and 4.2
                    if (value >= 1.0 && value <= 4.2)
                    {
                        _Engine = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            //The constructor for the car
            public Car(string brand, string model, int km, int year, int price,
                       double engine, double kmprl, int fuel, Dealer cardealer)
                : base(brand, model, km, year, price,
                  engine, kmprl, fuel, cardealer) { }
            
            //Second constructor for car
            public Car(string brand, string model, int year, int fuel, Dealer cardealer) 
                : base(brand, model, year, fuel, cardealer) { }

            public override string ToString()
            {
                //Calls the ToString method in the parent class, and adds veteran info
                return base.ToString() + "\n Veteran: " + Veteran;
            }
        }

        //Truck subclass of Vehicle
        public class Truck : Vehicle
        {
            public int PayLoad { get; set; }
            public bool Bunk { get; set; }
            public double Height { get; set; }
            public int Weight { get; set; }

            public override int TopSpeed
            {
                get { return _TopSpeed; }
                set
                {
                    //A truck has topspeed 95
                    _TopSpeed = 95;
                }
            }

            public override double Engine
            {
                get { return _Engine; }
                set
                {
                    //A truck has engine size between 5.0 and 15.0
                    if (value >= 5.0 && value <= 15.0)
                    {
                        _Engine = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            //A category c drivers license is required to drive a truck
            public override string DriverLicense
            {
                get { return _DriverLicense; }
                set { _DriverLicense = "You need a category C drivers license"; }
            }

            //Constructor for the truck
            public Truck(string brand, string model, int km, int year, int price,
                         double engine, double kmprl, int fuel, Dealer cardealer, int payload, bool bunk, double height, int weight)
                : base(brand, model, km, year, price,
                  engine, kmprl, 1, cardealer)
            {
                this.Bunk = bunk;
                this.PayLoad = payload;
                this.Height = height;
                this.Weight = weight;
                _DriverLicense = "You need a category C drivers license";
            }

            //Second constructor for Truck
            public Truck(string brand, string model, int year, int fuel, Dealer cardealer) 
                : base(brand, model, year, fuel, cardealer) { }

            public override string ToString()
            {
                return base.ToString() + "\n Bunk: " + Bunk + "\n Payload: " + PayLoad + "\n Weight: " + Weight + "\n Height: " + Height + "\n Drivers License: " + DriverLicense;
            }
        }

        //Van subclass of Vehicle
        public class Van : Vehicle
        {
            public int PayLoad { get; set; }
            Dimensions Dimension { get; set; }

            public override int TopSpeed
            {
                get { return _TopSpeed; }
                set
                {
                    //A van has topspeed 200
                    _TopSpeed = 200;
                }
            }

            public override double Engine
            {
                get { return _Engine; }
                set
                {
                    //A van has engine size between 2.0 and 4.2
                    if (value >= 2.0 && value <= 4.2)
                    {
                        _Engine = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public Van(string brand, string model, int km, int year, int price,
                       double engine, double kmprl, int fuel, Dealer cardealer, int payload, Dimensions dimension)
                : base(brand, model, km, year, price,
                       engine, kmprl, fuel, cardealer)
            {
                this.PayLoad = payload;
                this.Dimension = dimension;
            }

            //Second constructor for Van
            public Van(string brand, string model, int year, int fuel, Dealer cardealer) 
                : base(brand, model, year, fuel, cardealer) { }

            public override string ToString()
            {
                return base.ToString() + "\n Payload: " + PayLoad + "\n Dimensions: " + Dimension.Print();
            }
        }

        //Bus subclass of Vehicle
        public class Bus : Vehicle
        {
            public int Seatings { get; set; }
            public int Bunks { get; set; }
            public bool WC { get; set; }
            public double Height { get; set; }
            public int Weight { get; set; }

            public override int TopSpeed
            {
                get { return _TopSpeed; }
                set
                {
                    //A bus has topspeed 120
                        _TopSpeed = 120;
                }
            }

            public override double Engine
            {
                get { return _Engine; }
                set
                {
                    //A bus has engine size between 4.2 and 14.2
                    if (value >= 4.2 && value <= 14.2)
                    {
                        _Engine = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public override string DriverLicense
            {
                get { return _DriverLicense; }
                set { _DriverLicense = "You need a category C drivers license"; }
            }

            public Bus(string brand, string model, int km, int year, int price,
                       double engine, double kmprl, int fuel, Dealer cardealer, int seatings, int bunk, bool wc, double height, int weight)
                : base(brand, model, km, year, price,
                  engine, kmprl, 1, cardealer)
            {
                this.Seatings = seatings;
                this.Bunks = bunk;
                this.WC = wc;
                this.Height = height;
                this.Weight = weight;
                _DriverLicense = "You need a category C drivers license";
            }

            //Second constructor for Bus
            public Bus(string brand, string model, int year, int fuel, Dealer cardealer) 
                : base(brand, model, year, fuel, cardealer) { }

            public override string ToString()
            {
                return base.ToString() + "\n Seatings : " + Seatings + "\n Bunks: " + Bunks + "\n WC: " + WC + "\n Height: " + Height + "\n Weight: " + Weight + "\n Drivers license: " + DriverLicense;
            }
        }

        //AutoCamper subclass of Vehicle
        public class AutoCamper : Vehicle
        {
            int Seatings;
            int Bunks;
            private int _HeatingSystem;
            protected string[] HeatingName = { "Gas", "Electricity", "Oil" };


            public int HeatingSystem
            {
                get { return _HeatingSystem; }
                set
                {
                    if (value >= 0 && value <= 2)
                    {
                        _HeatingSystem = value;
                    }
                }
            }

            public string Heat
            {
                get { return HeatingName[HeatingSystem]; }
            }

            public override int TopSpeed
            {
                get { return _TopSpeed; }
                set
                {
                    //An autocamper has topspeed 180
                    _TopSpeed = 180;
                }
            }

            //The kmprl in autocamper is calculated baed on the type of heating system
            public override double KmPrL
            {
                get { return _KmPrL; }
                set
                {
                    if (HeatingSystem == 1)
                    {
                        _KmPrL = value * 0.9;
                    }
                    else if (HeatingSystem == 2)
                    {
                        _KmPrL = value * 0.8;
                    }
                    else
                    {
                        _KmPrL = value * 0.7;
                    }

                    if (_Fuel == 1)
                    {
                        if (_KmPrL > 25)
                        {
                            _EClass = 'A';
                        }
                        else if (_KmPrL > 20 && _KmPrL <= 25)
                        {
                            _EClass = 'B';
                        }
                        else if (_KmPrL > 15 && _KmPrL <= 20)
                        {
                            _EClass = 'C';
                        }
                        else
                        {
                            _EClass = 'D';
                        }
                    }
                    else
                    {
                        if (_KmPrL > 20)
                        {
                            _EClass = 'A';
                        }
                        else if (_KmPrL > 15 && _KmPrL <= 20)
                        {
                            _EClass = 'B';
                        }
                        else if (_KmPrL > 10 && _KmPrL <= 15)
                        {
                            _EClass = 'C';
                        }
                        else
                        {
                            _EClass = 'D';
                        }
                    }
                }
            }

            public override double Engine
            {
                get { return _Engine; }
                set
                {
                    //An autocamper has engine size between 2.4 and 6.2
                    if (value >= 2.4 && value <= 6.2)
                    {
                        _Engine = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public AutoCamper(string brand, string model, int km, int year, int price,
                              double engine, double kmprl, int fuel, Dealer cardealer, int seatings, int bunk, int heatingsystem)
                : base(brand, model, km, year, price,
                  engine, kmprl, fuel, cardealer)
            {
                this.Seatings = seatings;
                this.Bunks = bunk;
                this.HeatingSystem = heatingsystem;
            }

            //Second constructor for AutoCamper
            public AutoCamper(string brand, string model, int year, int fuel, Dealer cardealer) 
                : base(brand, model, year, fuel, cardealer) { }

            public override string ToString()
            {
                return base.ToString() + "\n Seatings: " + Seatings + "\n Bunks: " + Bunks + "\n HeatingSystem: " + Heat;
            }
        }

        //The car dealer class
        public class Dealer
        {
            private int _PhoneNumber;
            private string _Website;
            private bool _Firm = false;

            public bool Firm
            {
                get { return _Firm; }
                set { _Firm = value; }
            }

            public string Name { get; set; }
            public int ZipCode { get; set; }

            public int PhoneNumber
            {
                get { return _PhoneNumber; }
                set
                {
                    if (value.ToString().Length == 8)
                    {
                        _PhoneNumber = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public string Website
            {
                get { return _Website; }
                set
                {
                    if (value.Contains("http://www."))
                    {
                        _Website = value;
                    }
                    else
                    {
                        _Website = "http://www." + value;
                    }
                }
            }

            //Method that finds all vehicles handled by a specific seller
            public IEnumerable<Vehicle> GetAllByDealer(VehicleCollection CollectionOfVehicle, Dealer Seller)
            {

                IEnumerable<Vehicle> result =
                    from v in CollectionOfVehicle
                    where v.CarDealer == Seller
                    orderby v.Price ascending
                    select v;

                return result;
            }

            //The dealer constructor
            public Dealer(string name, int zipcode, int phonenumber, string website, bool firm)
            {
                this.Name = name;
                this.ZipCode = zipcode;
                this.PhoneNumber = phonenumber;
                this.Website = website;
                this.Firm = firm;
            }

            public override string ToString()
            {
                return ("Name: " + Name + "\n Zip Code: " + ZipCode + "\n PhoneNumber: " + PhoneNumber + "\n Website: " + Website + "\n Firm: " + Firm);
            }
        }

        //A collection class of vehicles
        public class VehicleCollection : ICollection<Vehicle>
        {
            private List<Vehicle> _VehicleList = new List<Vehicle>();


            //Method to add vehicles to the collection
            public void Add(Vehicle item)
            {
                if (!this.Contains(item))
                {
                    _VehicleList.Add(item);
                }

            }

            //Method to clear the list 
            public void Clear()
            {
                _VehicleList.Clear();
            }

            //Method to check if the current vehicle is already in the collection. Checks on values
            public bool Contains(Vehicle item)
            {
                bool indicator = false;

                foreach (Vehicle i in _VehicleList)
                {
                    if (i.ToString() == item.ToString())
                    {
                        indicator = true;
                    }
                }

                return indicator;
            }


            //Allow us to use [] notation to get a vehicle on a specific index
            public Vehicle this[int index]
            {
                get
                {
                    return _VehicleList[index];
                }
                set
                {
                    _VehicleList[index] = value;
                }
            }


            //CopyTo method
            public void CopyTo(Vehicle[] array, int arrayIndex)
            {
                _VehicleList.CopyTo(array, arrayIndex);
            }

            //Count method, returns number of vehicles in the list
            public int Count
            {
                get { return _VehicleList.Count(); }
            }

            //Required implementation by the Icollection interface. Returns false
            public bool IsReadOnly
            {
                get { return false; }
            }

            //Method which removes a vehicle from the list
            public bool Remove(Vehicle item)
            {
                bool indicator = false;
                foreach (Vehicle i in _VehicleList)
                {
                    if (i == item)
                    {
                        _VehicleList.Remove(i);
                        indicator = true;
                        break;
                    }
                }
                return indicator;
            }

            //Method allowing a foreach to be called on the vehiclecollection class
            public IEnumerator<Vehicle> GetEnumerator()
            {
                foreach (Vehicle v in _VehicleList)
                {
                    yield return v;
                }
            }

            //Required implementation by the Icollection interface.
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            //Method that finds vehicles by brand and model
            public IEnumerable<Vehicle> FindByBrandAndModel(string Brand, string Model)
            {
                IEnumerable<Vehicle> result =
                    from v in _VehicleList
                    where v.Brand == Brand && v.Model == Model
                    orderby v.Price ascending
                    select v;

                return result;
            }

            //Method which finds vehicles by the dealers zip code
            public IEnumerable<Vehicle> FindByZipcode(int Zipcode)
            {
                //Linq expression used to find vehicles where the dealers zip code is 'Zipcode'
                IEnumerable<Vehicle> result =
                    from v in _VehicleList
                    where v.CarDealer.ZipCode == Zipcode
                    orderby v.Price ascending
                    select v;
                return result;
            }

            //Class needed by the FindByPayLoad method, to sort the vehicles by size of payload
            private class PayloadandVehicle
            {
                public int PayLoad { get; set; }
                public Vehicle Vehicle { get; set; }

            }

            //Method which finds vehicles by a minimum payload
            public IEnumerable<Vehicle> FindByPayload(int Payload)
            {
                List<Vehicle> result = new List<Vehicle>();
                List<PayloadandVehicle> result2 = new List<PayloadandVehicle>();

                foreach (Vehicle v in _VehicleList)
                {
                    if (v is Truck)
                    {
                        Truck tmp = (Truck)v;
                        if (tmp.PayLoad >= Payload)
                        {
                            PayloadandVehicle tmp2 = new PayloadandVehicle();
                            tmp2.Vehicle = v;
                            tmp2.PayLoad = tmp.PayLoad;
                            result2.Add(tmp2);
                        }
                    }
                    else if (v is Van)
                    {
                        Van tmp = (Van)v;
                        if (tmp.PayLoad >= Payload)
                        {
                            PayloadandVehicle tmp2 = new PayloadandVehicle();
                            tmp2.Vehicle = v;
                            tmp2.PayLoad = tmp.PayLoad;
                            result2.Add(tmp2);
                        }
                    }
                }

                IEnumerable<Vehicle> results =
                    from v in result2
                    orderby v.PayLoad ascending
                    select v.Vehicle;

                return results;
            }

            //Method which finds vehicles by a max price, that also requires a category c drivers license
            public IEnumerable<Vehicle> FindByDriversLicenseAndMaximumPrice(int max_price)
            {
                List<Vehicle> result = new List<Vehicle>();

                foreach (Vehicle v in _VehicleList)
                {
                    if (v.DriverLicense != null && v.Price < max_price)
                    {
                        result.Add(v);
                    }

                }
                return result;
            }

            //The method allowing users to seach for anything in the vehicles
            public IEnumerable<Vehicle> Search(string query)
            {
                List<Vehicle> result = new List<Vehicle>();

                foreach (Vehicle v in _VehicleList)
                {
                    //Check if the ToString contains the seach query
                    if (v.ToString().Contains(query))
                    {
                        result.Add(v);
                    }
                }
                //Sort the list
                IEnumerable<Vehicle> results =
                    from v in result
                    orderby v.Price ascending
                    select v;
                return results;
            }
        }

        static void Main(string[] args)
        {
            //Initialize som vehicles for testing purposes
            Dealer John = new Dealer("John Davidson", 9000, 98123456, "sjovmedtal.dk", false);
            Dealer CarTek = new Dealer("CarTek", 2500, 21999991, "cartak.com", true);

            Car SkodaFabia = new Car("Skoda", "Fabia", 10000, 2007, 25000, 2.0, 19.0, 2, John);
            Car VWToureg = new Car("VW", "Toureg", 0, 2012, 900000, 2.1, 21.0, 2, CarTek);
            
            Truck VolvoFE = new Truck("Volvo", "FE", 100000, 2002, 45000, 8.0, 15.0, 0, John, 50000, true, 200.0, 4000);
            Truck VolvoFMX = new Truck("Volvo", "FMX", 120000, 2001, 24000, 7.0, 13.5, 0, CarTek, 40000, false, 210.0, 4500);
            
            Van FiatDucato = new Van("Fiat", "Ducato", 10000, 1998, 20000, 2.4, 14.2, 1, CarTek, 500, new Dimensions(200.0, 150.0, 400.0));
            
            Bus ScaniaEuro = new Bus("Scania", "Euro", 200000, 2001, 250000, 9.0, 10.0, 0, John, 52, 52, false, 250.0, 8000);
            
            AutoCamper BürstnerDelfin = new AutoCamper("Bürstner", "Delfin", 1900, 400000, 70, 2.8, 11.9, 0, John, 5, 8, 1);

            VehicleCollection CollectionOfVehicle = new VehicleCollection();

            //Add them to the list
            CollectionOfVehicle.Add(SkodaFabia);
            CollectionOfVehicle.Add(VWToureg);
            CollectionOfVehicle.Add(VolvoFE);
            CollectionOfVehicle.Add(VolvoFMX);
            CollectionOfVehicle.Add(FiatDucato);
            CollectionOfVehicle.Add(ScaniaEuro);
            CollectionOfVehicle.Add(BürstnerDelfin);

            bool run = false;

            //Show the menu
            while (run == false)
            {
                    int ChoiceMain;
                    Console.WriteLine("Select one of the choices:");
                    Console.WriteLine("1: Show all data");
                    Console.WriteLine("2: Search by Brand and Model");
                    Console.WriteLine("3: Search by ZipCode");
                    Console.WriteLine("4: Search by Payload");
                    Console.WriteLine("5: Search by big driver licens and a maximum price");
                    Console.WriteLine("6: Search in all fields");
                    Console.WriteLine("7: Exit!");
                    Console.Write("Your choice: ");
                    try
                    {
                        ChoiceMain = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        ChoiceMain = 8;
                    }
                    catch (OverflowException) 
                    {
                        ChoiceMain = 8;
                    }

                    //Handle the menu choice
                    switch (ChoiceMain)
                    {
                        case 1:
                            Console.WriteLine("");
                            foreach (Vehicle v in CollectionOfVehicle)
                                {
                                    Console.WriteLine(v.ToString());
                                    Console.WriteLine("------------------");
                                }
                            break;

                        case 2:
                            Console.WriteLine("Type the brand of the vehicle: ");
                            string BrandName = Console.ReadLine();
                            Console.WriteLine("Type the model of the vehicle: ");
                            string ModelName = Console.ReadLine();
                            Console.WriteLine("");
                            var SearchResultBrandModel = CollectionOfVehicle.FindByBrandAndModel(BrandName, ModelName);
                            foreach (Vehicle v in SearchResultBrandModel)
                            {
                                Console.WriteLine(v.ToString());
                                Console.WriteLine("------------------");
                            }
                            break;

                        case 3:
                            try
                            {
                                Console.WriteLine("Type the zipcode you wish to find vehicles within: ");
                                int ZipCode = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                var TmpSearchResultZipcode = CollectionOfVehicle.FindByZipcode(ZipCode);
                                foreach (Vehicle v in TmpSearchResultZipcode)
                                {
                                    Console.WriteLine(v.ToString());
                                    Console.WriteLine("------------------");
                                }
                            }
                            catch (FormatException) 
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("Please use only integers, no strings or decimals");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("The integer was to big!");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            break;

                        case 4:
                            try
                            {
                                Console.WriteLine("Type minimum payload for the vehicles you wish to find: ");
                                int PayLoad = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                var TmpSearchResultPayload = CollectionOfVehicle.FindByPayload(PayLoad);
                                foreach (Vehicle v in TmpSearchResultPayload)
                                {
                                    Console.WriteLine(v.ToString());
                                    Console.WriteLine("------------------");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("Please use only integers, no strings or decimals");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("The integer was to big!");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            break;

                        case 5:
                            try
                            {
                                Console.WriteLine("Type the max price of the vehicles you wish to find (All vehicles that demands a big driver license): ");
                                int MaxPrice = int.Parse(Console.ReadLine());
                                Console.WriteLine("");
                                var TmpSearchResultMaxPrice = CollectionOfVehicle.FindByDriversLicenseAndMaximumPrice(MaxPrice);
                                foreach (Vehicle v in TmpSearchResultMaxPrice)
                                {
                                    Console.WriteLine(v.ToString());
                                    Console.WriteLine("------------------");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("Please use only integers, no strings or decimals");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine("------------------");
                                Console.WriteLine("The integer was to big!");
                                Console.WriteLine("------------------");
                                Console.WriteLine("");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Type a word you wish to search for ");
                            string DesiredInput = (Console.ReadLine());
                            Console.WriteLine("");
                            var TmpSearchResultDesiredinput = CollectionOfVehicle.Search(DesiredInput);
                            foreach (Vehicle v in TmpSearchResultDesiredinput)
                            {
                                Console.WriteLine(v.ToString());
                                Console.WriteLine("------------------");
                            }
                            break;

                        case 7:
                            run = true;
                            break;

                        default:
                            Console.WriteLine("------------------");
                            Console.WriteLine("Your choice is invalid, try again");
                            Console.WriteLine("------------------");
                            Console.WriteLine("");
                            break;
                    }
            }
        }
    }
}
