using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace opgave_1
{
    
    
    public class Stock
    {
        
        
        public string Name { get; private set; }
        public decimal MaxValue { get; private set; }
        public decimal MinValue { get; private set; }
        public decimal PreviousValue { get; private set; }
         public Stock(string name) { this.Name = name; }
        //State change that prompts event to be fired
            
        public class ValueArgs : EventArgs
        {
            //Properties
            
            private decimal _currentValue;
       
            public ValueArgs(decimal value)
            {
                this.Value = value;

            }

            public decimal Value
            {
                get { return _currentValue; }

            }
        }

        // public void noget<T>(object sender, T eventArgs) where T : EventArgs;
        public event EventHandler<ValueArgs> OnStockchange;



    }
    
 
    public class Person
    {
        void OnStockChanged(object sender, Stock.StockArgs e)
        {    
            Console.WriteLine("lol");   
            
            
        } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person Morten = new Person();
            Stock Ting = new Stock();
            Ting.OnStockchange += Morten;

        }
    }

}
