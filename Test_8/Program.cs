using System;
using System.Collections.Generic;

namespace Test_8
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            //Problem 8 Object
            Problem8 p8 = new Problem8();

			//Problem 9 Object
			Problem9 p9 = new Problem9();

            //Problem 10 Object
            Problem10 p10 = new Problem10();

            //Problem 11 Objeect
            Problem11 p11 = new Problem11();

            //Problem 12 Object

            Problem12 p12 = new Problem12();

            //Problem 8 Output
            //Console.WriteLine(p8.countUnset(65535));
            //Console.WriteLine(p8.countUnset(12547));


            //Add condition to check
            //(Multiplier, Text)
            //p9.addCondition(3, "Fizz");
            //p9.addCondition(5, "Buzz");

            //Problem 9 Output
            //Console.WriteLine(p9.multiply());

            //Problem 10 Output
            //Console.WriteLine("Insert your year of birth");
            //string input = Console.ReadLine();
            //Console.WriteLine(p10.calculateAge(input));


            /*int [] arr1 = new int[] { 4, 5, 7, 9, 10, 34};
            int [] arr2 = new int[] { 1, 3, 6, 8, 32, 33};
            var array = p11.merge(arr1, arr2);
            string output = "";
            foreach (var x in array){
                output += x + " ";
            }*/

            //Problem 11 Output
            //Console.WriteLine(output);

            string json = "{Paulina: {dob: 1815,children: {Juan: {dob: 1850,children: {Mathew: {dob: 1867}}},Karina: {dob: 1840}}},Brandon: {dob: 1820},Raul: {dob: 1825,children: {Pedro: {dob: 1861}}}}";
            Console.WriteLine(p12.ListWithNames(json));
            Console.WriteLine(p12.oldRecent(json));



        }
    }
}
