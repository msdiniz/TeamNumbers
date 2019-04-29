using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNumbers
{
    class RetiredTeamNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public RetiredTeamNumber(string player, int yearRetired)
        {
            Player = player;
            YearRetired = yearRetired;
        }
    }
}
