using System;

//Broc Keeton
//IT112
//NOTES: Added a "clear" option.
//BEHAVIORS NOT IMPLEMENTED AND WHY: Program works as described in assignment. 
//However, string Product not implemented not sure where to use it with the
//way I completed this assginment.

namespace Keeton_Inventory
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var shipper = new Shipper();
            shipper.Add();           
        }
    }
}
