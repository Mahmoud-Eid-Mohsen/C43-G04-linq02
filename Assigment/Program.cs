using Assigment.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using  static Assigment.Data.ListGenerator;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Element Operators
            // //1. Get first Product out of Stock 


            // var result = ProductsList.FirstOrDefault(p=>p.UnitsInStock==0);


            //// 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            // var Result = ProductsList.FirstOrDefault(p => p.UnitPrice>1000);


            //// 3.Retrieve the second number greater than 5
            //  int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var ResulT = Arr.Where(p => p > 5).ElementAtOrDefault(1);

            #endregion
            #region Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
           int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result = Arr.Count(p=>p%2!=0);



            //2.Return a list of customers and how many orders each has.

            var Resul = from c in CustomersList
                        from o in c.Orders
                        select  new 
                        {
                            c.CustomerName,
                           ordercount = c.Orders.Length

                        };






            //3. Return a list of categories and how many products each has


           
            var listcategory = from p in ProductsList
                               select new
                               { 
                                   categoryname= p.Category,
                                   countofcategory = p.Category.Count()


                               };

          


            //4.Get the total of the numbers in an array.
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result2 = Arr2.Count();
            //---------------------------------------------------------------------------
            string filePath = @"D:\Route.net course\5_Linq\Session 02\Assignment\Day02\Assigment\dictionary_english.txt";
            var txtfile = File.ReadLines(filePath).ToArray();
            // 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt
            // into Array of String First).
            var totalchar=txtfile.Sum(p=>p.Length);
           


            //6. Get the length of the shortest word
            //in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            var lengthshorte=txtfile.Min(p=>p.Length);


            //7. Get the length of the longest word
            var lengthlongest = txtfile.Max(p => p.Length);







            //  8.Get the average length of the words in dictionary_english.txt
            //  (Read dictionary_english.txt into Array of String First).



            var Result3 = txtfile.Average(w=>w.Length);
            Console.WriteLine(Result3);




            #endregion
            #region Set Operators
            //1. Find the unique Category names from Product List
            var uniqueCategorynames = ProductsList.Select(p => p.Category).Distinct().ToList();
            
            



            //2. Produce a Sequence containing the unique first letter from both
            //product and customer names.
            var UFLProductCustomer = ProductsList.Select(p => p.ProductName[0]).Concat(CustomersList.Select(c => c.CustomerName[0])).Distinct();


            //3. Create one sequence that contains the common
            //first letter from both product and customer names.
             UFLProductCustomer = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0]));



            //4. Create one sequence that contains the first letters of product names that are not
            //also first letters of customer names
            UFLProductCustomer = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0]));



            //5.Create one sequence that contains the last Three Characters in each name of all
            //customers and products, including any duplicates


            var lastthree = ProductsList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
                .Concat(CustomersList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName));
            var n = ProductsList.Select(p => p.ProductName);
            foreach (var item in lastthree)
                Console.WriteLine(item);


            #endregion
        }
    }
}
