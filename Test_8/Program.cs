using System;
using System.Collections.Generic;

namespace Test_8
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            
            MainClass mainClass = new MainClass();

			//Call of Problem 8
			//mainClass.problem8();

			//Call of Problem 9
			//mainClass.problem9();

			//Call of Problem 10
			//mainClass.problem10();

			//Call of Problem 11
			//mainClass.problem11();

			//Call of Problem 12
			mainClass.problem12();


        }
        public void problem8(){
            Problem8 p8 = new Problem8();
            //Problem 8 Output and return of the unset bits with countUnset(int number)
			Console.WriteLine(p8.countUnset(65535));
			Console.WriteLine(p8.countUnset(12547));    
		}
        public void problem9(){
            Problem9 p9 = new Problem9();

			//Add condition to check
			//(Multiplier, Text)
			p9.addCondition(3, "Fizz");
			p9.addCondition(5, "Buzz");

            //Problem 9 Output and return of the text with method multiply()
			Console.WriteLine(p9.multiply());

		}
        public void problem10(){
            Problem10 p10 = new Problem10();
			Console.WriteLine("Insert your year of birth");
			string input = Console.ReadLine();
            //Problem 10 Output and return of Age with method calculateAge(int year)
			Console.WriteLine(p10.calculateAge(input));    
		}
        public void problem11(){
            Problem11 p11 = new Problem11();
			int [] arr1 = new int[] { 4, 5, 7, 9, 10, 34};
            int [] arr2 = new int[] { 1, 3, 6, 8, 32, 33};

            //Return of the merge array
            var array = p11.merge(arr1, arr2);

            string output = "";
            foreach (var x in array){
                output += x + " ";
            }

            //Problem 11 Output
            Console.WriteLine(output);

		}
        public void problem12(){
            Problem12 p12 = new Problem12();
            //lecture of path
			Console.WriteLine("Path of TXT file with json");
			String path = "";
			String[] text = null;
			try
			{
				path = Console.ReadLine();
				path = path.Split(' ')[0];
				text = System.IO.File.ReadAllLines(path);


				string json = "";
				for (int i = 0; i < text.Length; i++)
				{
					json += text[i];
				}
                //return of names with method ListWithNames(string json)
				Console.WriteLine(p12.ListWithNames(json));
                //Return of oldest and recent dob with method oldRecent(string json)
				Console.WriteLine(p12.oldRecent(json));
			}
			catch (Exception e)
			{
				Console.WriteLine("Cannot read file, check if there is no spaces at the final of the path");
			}
        }
    }
}
