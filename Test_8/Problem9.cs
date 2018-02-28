using System;
using System.Collections.Generic;

namespace Test_8
{
    public class Problem9
    {
        private List<Multiply> cond;

        public Problem9()
        {
            cond = new List<Multiply>();
        }
        public String multiply(){
            String outputText = "";
            String msg = "";
            for (int i = 1; i <= 100; i++ ){
                foreach (Multiply x in cond){
                    if ((i % x.mult) == 0){
                        msg += x.text;
                    }
                }
                if (msg == ""){
                    outputText += i.ToString() + " ";    
                } else{
                    outputText += msg + " ";
                    msg = "";
                }

            }
            return outputText;
        }
        public void addCondition(int number, string phrase){
			cond.Add(new Multiply()
			{
				mult = number,
				text = phrase
			});
        }

    }
    public class Multiply{

        public int mult { set; get; }
        public string text { set; get; }

        public Multiply(){
            
        }
    }
}
