using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNumbers
{
    class TeamKey
    {
        public TeamKey(int retiredNumber,Team teamName,int retiredNumberCopy)
        {
            TeamName = teamName.ToString();
            Team = teamName;
            RetiredNumber = retiredNumber;
            RetiredNumberCopy = retiredNumberCopy;
        }
        public string TeamName { get; set; }
        public Team Team { get; set; }
        public int RetiredNumber { get; set; }
        public int RetiredNumberCopy { get; set; } //if no more than one equal number = 1, else = 2, etc...
        //https://stackoverflow.com/questions/46023726/c-sharp-dictionary-with-class-as-key
        public override int GetHashCode()
        {
            return (RetiredNumber);
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as TeamKey);
        }
        public bool Equals(TeamKey obj)
        {
            return obj != null && obj.RetiredNumber == this.RetiredNumber && obj.RetiredNumberCopy == this.RetiredNumberCopy;
        }
    }
}
