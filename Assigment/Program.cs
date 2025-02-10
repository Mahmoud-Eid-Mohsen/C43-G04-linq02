using Assigment.Data;
using System.Diagnostics;
using  static Assigment.Data.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Element Operators
            //1. Get first Product out of Stock 


            var result = ProductsList.FirstOrDefault(p=>p.UnitsInStock==0);


           // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var Result = ProductsList.FirstOrDefault(p => p.UnitPrice>1000);


           // 3.Retrieve the second number greater than 5
             int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var ResulT = Arr.Where(p => p > 5).ElementAtOrDefault(1);
            
                #endregion
        }
    }
}
