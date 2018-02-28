using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Test_8
{
    public class Problem12
    {
        List<int> dob = new List<int>();
        public Problem12()
        {
        }
        public String ListWithNames(String json)
        {
            var jsonParsed = JObject.Parse(json);
            List<Persons> list = Asign(jsonParsed);
            return getNamesAndDob(list);

		}
        public String oldRecent(String json){
			var jsonParsed = JObject.Parse(json);
			List<Persons> listPersons = Asign(jsonParsed);
            dob.Sort();
            return "Oldest: " + dob[0] + ", Recent: " + dob[dob.Count()-1];
        }

        public String getNamesAndDob(List<Persons> list){
            String name = "";
            for (int i = 0; i < list.Count(); i++)
            {
                
                name += list[i].name + " ";
                dob.Add(list[i].dob);
                if (list[i].children != null)
                {
                    name += getNamesAndDob(list[i].children);
                }
            }
            return name;
        } 


        public List<Persons> Asign(JObject jObject)
        {
            List<Persons> list = new List<Persons>();
            var jProperties = jObject.Properties().ToList();
            for (int i = 0; i < jProperties.Count(); i++)
            {
                Persons p = new Persons()
                {
                    name = jProperties[i].Name,
                    dob = jObject[jProperties[i].Name]["dob"].Value<int>()
                };
                try
                {
                    var newJObject = jObject[jProperties[i].Name]["children"].Value<JObject>();
                    p.children = Asign(newJObject);
                    list.Add(p);
                }catch(Exception e){
                    list.Add(p);
                }

            }
            return list;
        }

    }
}





public class Persons
{
    public string name { set; get; }
    public int dob { set; get; }
    public List<Persons> children { set; get; }

    public Persons(){
        name = "";
        dob = 0;
        children = null;    
    }
}

