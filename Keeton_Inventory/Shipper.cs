using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Keeton_Inventory
{
    public class Shipper : IShippable
    {
        decimal Bicycle = 9.50M;
        decimal LawnMower = 24.00M;
        decimal BaseballGlove = 3.23M;
        decimal Crackers = .57M;

        int _Bicycle = 0;
        int _LawnMower = 0;
        int _BaseballGlove = 0;
        int _Crackers = 0;

        private decimal _shipcost = 0.00M;
        public decimal ShipCost
        {
            get { return _shipcost; }
        }
        private string _product;//not sure how to implement this
        public string Product
        {
            get { return _product; }
        }
        public void Add()
        {
            
            Console.WriteLine("\nChoose an item from the Inventory List:");
            Console.WriteLine("1 : Bicycle (Ship Cost: $9.50)");
            Console.WriteLine("2 : Lawn Mower (Ship Cost: $24.00)");
            Console.WriteLine("3 : Baseball Glove (Ship Cost: $3.23)");
            Console.WriteLine("4 : Crackers (Ship Cost: $.57)");
            Console.WriteLine("5 : List Shipment Items");
            Console.WriteLine("6 : Compute Shipping Charges");
            Console.WriteLine("0 : Clear Items From Inventory Cart\n");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\n1 Bicyle has been added to your Shipment Manifest.");
                    _shipcost += Bicycle;
                    _Bicycle++;
                    Console.WriteLine("Shipping Total: $" + _shipcost);
                    Thread.Sleep(2500);
                    Console.Clear();
                    Add();
                    break;

                case "2":
                    Console.WriteLine("\n1 Lawn Mower has been added to your Shipment Manifest.");
                    _shipcost += LawnMower;
                    _LawnMower++;
                    Console.WriteLine("Shipping Total: $" + _shipcost);
                    Thread.Sleep(2500);
                    Console.Clear();
                    Add();
                    break;

                case "3":
                    Console.WriteLine("\n1 Baseball Glove has been added to your Shipment Manifest.");
                    _shipcost += BaseballGlove;
                    _BaseballGlove++;
                    Console.WriteLine("Shipping Total: $" + _shipcost);
                    Thread.Sleep(2500);
                    Console.Clear();
                    Add();
                    break;

                case "4":
                    Console.WriteLine("\n1 Crackers has been added to your Shipment Manifest.");
                    _shipcost += Crackers;
                    _Crackers++;
                    
                    Console.WriteLine("Shipping Total: $" + _shipcost);
                    Thread.Sleep(2500);
                    Console.Clear();
                    Add();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("\nShipment manifest: ");

                    if(_Bicycle == 0)
                    {
                        //blank for no selection yet
                    }
                    else if(_Bicycle == 1)
                    {
                        Console.WriteLine(_Bicycle + " Bicycle");
                    }
                    else
                    {
                        Console.WriteLine(_Bicycle + " Bicycles");
                    }

                    if (_LawnMower == 0)
                    {
                        //blank for no selection yet
                    }
                    else if (_LawnMower == 1)
                    {
                        Console.WriteLine(_LawnMower + " Lawn Mower");
                    }
                    else
                    {
                        Console.WriteLine(_LawnMower + " Lawn Mowers");
                    }

                    if (_BaseballGlove == 0)
                    {
                        //blank for no selection yet
                    }
                    else if (_BaseballGlove == 1)
                    {
                        Console.WriteLine(_BaseballGlove + " Baseball Glove");
                    }
                    else
                    {
                        Console.WriteLine(_BaseballGlove + " Baseball Gloves");
                    }

                    if (_Crackers == 0)
                    {
                        //blank for no selection yet
                    }
                    else if (_Crackers == 1)
                    {
                        Console.WriteLine(_Crackers + " Crackers");
                    }
                    else
                    {
                        Console.WriteLine(_Crackers + " Crackers");
                    }

                    Console.WriteLine("Shipping Total: $" + _shipcost);
                    Add();
                    break;
               
                case "6":
                    Console.WriteLine("\nTotal shipping cost for this order is $" + _shipcost + ".");
                    break;

                case "0":
                    _Bicycle = 0;
                    _LawnMower = 0;
                    _BaseballGlove = 0;
                    _Crackers = 0;
                    _shipcost = 0.00M;
                    Console.WriteLine("\nYour Shipment Manifest has been cleared.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Add();
                    break;

                default:
                    Console.WriteLine("Please select an item from the Inventory List.\n");
                    Add();
                    break;
            }
        }
    }
}
