using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ibbi = new Person(Sex.Female,"Peter Pedal", 1);
            
            Console.WriteLine(Ibbi.Name +" "+ Ibbi.Sex +" "+ Ibbi.Age);
            Console.ReadLine();
        }


    public enum Sex { Male, Female } 
 
    public class Person 
    { 
        #region Konstanter 
        public const int MAX_ADULT_MALE_WEIGHT   = 150; 
        public const int MIN_ADULT_MALE_WEIGHT   =  65; 
        public const int MAX_ADULT_FEMALE_WEIGHT = 120; 
        public const int MIN_ADULT_FEMALE_WEIGHT =  45; 
        public const int MAX_CHILD_WEIGHT        = 100; 
        public const int MIN_CHILD_WEIGHT        =   0; 
        #endregion 
         
        #region Instans-variable 
        //Demo 
        [ContractPublicPropertyName("Age")] 
        private int _age; 
        private double _weight; 
        private string _name; 
        private Sex _sex; 
        #endregion 
 
        #region Properties 
        //min og max vægt afhængig af køn (og alder)   
        public Sex Sex 
        { 
            get { return _sex; } 
            set { _sex = value; } 
        } 
 
        //hvis alder < 0, så kast ArgumentException 
        public int Age 
        { 
            get { return _age; }
            set
            {
                Contract.Requires<ArgumentException>(value >= 0);
                if (this.Sex == Sex.Female && value > 29)
                {
                    _age = 29;
                }
                else
                {
                    _age = value;
                }
            }

        } 
                 
        public double Weight 
        { 
            get { return _weight; } 
            set { 
                if (Age < 15) 
                { 
                    if (value      < MIN_CHILD_WEIGHT) 
                        _weight    = MIN_CHILD_WEIGHT; 
                    else if (value > MAX_CHILD_WEIGHT) 
                        _weight    = MAX_CHILD_WEIGHT; 
                    else 
                        _weight = value;                     
                } 
                else 
                { 
                    if (this.Sex == Sex.Female)                     { 
                        if (value      < MIN_ADULT_FEMALE_WEIGHT) 
                            _weight    = MIN_ADULT_FEMALE_WEIGHT; 
                        else if (value > MAX_ADULT_FEMALE_WEIGHT) 
                            _weight    = MAX_ADULT_FEMALE_WEIGHT; 
                        else 
                            _weight = value;                       
                    } 
                    else 
                    { 
                        if (value      < MIN_ADULT_MALE_WEIGHT) 
                            _weight    = MIN_ADULT_MALE_WEIGHT; 
                        else if (value > MAX_ADULT_MALE_WEIGHT) 
                            _weight    = MAX_ADULT_MALE_WEIGHT; 
                        else 
                            _weight = value;                         
                    } 
                } 
            } 
        } 
 
        //Tjekkes via objekt-invariant 
        public string Name 
        { 
            get { return _name; } 
            set {
                    if (value == null)
                    {
                        if (this.Sex == Sex.Female)
                        {
                            _name = "Jane Due";
                        }
                        else
                        {
                            _name = "John Due";
                        }
                    }
                    else
                    {
                        _name = value; 
                    } 
                }
        } 
        #endregion

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_name.All((char c) => { return Char.IsLetter(c) || Char.IsWhiteSpace(c); }));
        }
        //metode der tæller alderen op med ét år 
        public void ItsYourBirthDay() 
        {             
            Age++;  
        } 
 
        #region Constructors 
        public Person(Sex sex) 
        { 
            Initialize(sex, sex == Sex.Male ? "John Doe" : "Jane Doe", 0); 
        } 
 
        public Person(Sex sex, string name) 
        { 
            Initialize(sex, name, 0); 
        } 
 
        public Person(Sex sex, string name, int age) 
        { 
            Initialize(sex, name, age); 
        }         
 
        private void Initialize(Sex sex,string name, int age) 
        {  
            this.Sex = sex;
            this.Name = name;
            this.Age = age;  
        }
#endregion 
    }  
    }
}
