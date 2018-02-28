using System;
namespace Test_8
{
    public class Problem8
    {
        public Problem8()
        {
            
        }

        public int countUnset(int number)
        {
            String binary =  Convert.ToString(number, 2);
            int count = 0;
            for (int i = 0; i < binary.Length; i++){
                if ((char)binary[i] == '0'){
                    count++;        
                }
            }
            if (binary.Length < 16){
                count += 16 - binary.Length;
            }
            return count;
        }
    }
}
