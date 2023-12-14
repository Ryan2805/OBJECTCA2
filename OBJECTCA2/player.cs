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
        public string ResultRecord { get; set; }

        public int CalculatePoints()
        {
            //make sure the  ResultRecord is not null and has at least 5 characters
            if (!string.IsNullOrEmpty(ResultRecord) && ResultRecord.Length >= 5)
            {
                int points = 0;

                // for loop for the results
                for (int i = ResultRecord.Length - 1; i >= ResultRecord.Length - 5; i--)
                {
                    switch (ResultRecord[i])
                    {
                        case 'W':
                            points += 3;
                            break;
                        case 'D':
                            points += 1;
                            break;

                    }
                }
                return points;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"{Name} - Result Record: {ResultRecord}";
        }
    }


}


  
