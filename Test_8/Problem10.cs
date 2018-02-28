using System;
namespace Test_8
{
    public class Problem10
    {
        public const int actualYear = 2018;
        public const int humanLifeSpan = 100;

        public Problem10()
        {
        }
        public String calculateAge(string input){
            try{
                int year;
                if (input.Contains(".")){
                    //Error
                    throw new Exception("Error input is a decimal number");

                }
                if (int.TryParse(input, out year) == false){
                    //Error
                    throw new Exception("Error input isn't a number.");
                }
                if (year < 0){
                    throw new Exception("The year is a negative number");
                }

                var res = actualYear - year;
                if (res < 0){
                    //Error
                    throw new Exception("Year inserted is bigger than actual year");
                }

				if (res > humanLifeSpan)
				{
					//Error
					throw new Exception("Age outside human lifespan");

				}

                return "Your age is : " + res.ToString();

            }catch(Exception e){
                return e.ToString();
            }

          
        }
    }
}
