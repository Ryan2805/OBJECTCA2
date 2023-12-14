using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTCA2
{
    internal class Player
    {
        public string Name { get; set; }
        public  string ResultRecord { get; set; }





        //adding the overide string
        public override string ToString()
        {
            return $"{Name} - {ResultRecord}";
        }
    }
}
