using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _P_Solved_Classes_and_files_1
{
    public class Toy
    {
          public string Manufacturer {get;set;}  
          public string Name         {get;set;}  
          public double Price        {get;set;}  
          public string Image        {get;set;}

          private string Aisle;
        //constructor can be written pressing the ctor tab twice

        public Toy()
        {
            Manufacturer =string.Empty;
            Name         =string.Empty;
            Price        =0;
            Image        = string.Empty;

            /*for future reference: if you write anything here, every instance of the class will have that word
             *  example:
             *  Manufacturer ="adidas"; */
        }

        public string GetAisle()
        {
            Aisle = Manufacturer[0].ToString().ToUpper()+ Price.ToString().Replace(",","").Replace(".","").Replace("$","");
            return Aisle;
        }

    }
}
