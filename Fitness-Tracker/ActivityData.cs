using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class ActivityData
    {
        public int id { get; set; }
        public string name { get; set; }
        public int goalId { get; set; }
        public int calorieBurned { get; set; }
        public DateTime date { get; set; }
        

    }
}
