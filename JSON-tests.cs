using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace JSONtesting
{
    public class App
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
             //test1();
             test2();
        }
private static void test2()
{
string json = @"{
  'key1': {'field1':'abc', 'field2':'cde'},
  'key2': {'field1':'fgh', 'field2':'ijk'}
  }";
Dictionary<string, object> values = 
JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

Console.WriteLine("found "+values.Count+" objects");
Console.WriteLine("dict test 1:"+values["key2"]);
//object jsonObject = values["key2"];
Console.WriteLine("dict test 2:"+
(values["key2"]).GetType());

Newtonsoft.Json.Linq.JObject oneObj 
= values["key2"] as Newtonsoft.Json.Linq.JObject;

Console.WriteLine("dict test 3:"+oneObj["field1"]);
}
 
                
private static void test1()
        {           
        Dictionary<string, int> points = new Dictionary<string, int>
{
    { "James", 9001 },
    { "Jo", 3474 },
    { "Jess", 11926 }
};

string json = JsonConvert.SerializeObject(points, Formatting.Indented);

Console.WriteLine(json);
            
        }
    }
}
