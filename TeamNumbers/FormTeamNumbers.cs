using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNumbers
{
    public partial class FormTeamNumbers : Form
    {
        Dictionary<TeamKey, RetiredTeamNumber> retiredNumbers = new Dictionary<TeamKey, RetiredTeamNumber>() {
       {new TeamKey(3,Team.Jersey,1), new RetiredTeamNumber("Babe Ruth", 1948)},
       {new TeamKey(4,Team.Jersey,1), new RetiredTeamNumber("Lou Gehrig", 1939)},
       {new TeamKey(5,Team.Jersey,1), new RetiredTeamNumber("Joe DiMaggio", 1952)},
       {new TeamKey(7,Team.Jersey,1), new RetiredTeamNumber("Mickey Mantle", 1969)},
       {new TeamKey(8,Team.Jersey,1), new RetiredTeamNumber("Yogi Berra", 1972)},
       {new TeamKey(10,Team.Jersey,1), new RetiredTeamNumber("Phil Rizzuto", 1985)},
       {new TeamKey(23,Team.Jersey,1), new RetiredTeamNumber("Don Mattingly", 1997)},
       {new TeamKey(42,Team.Jersey,1), new RetiredTeamNumber("Jackie Robinson", 1993)},
       {new TeamKey(44,Team.Jersey,1), new RetiredTeamNumber("Reggie Jackson", 1993)},
       {new TeamKey(44,Team.Jersey,2), new RetiredTeamNumber("Connie Jamieson", 1986)},
  };

        public FormTeamNumbers()
        {
            InitializeComponent();
            foreach (TeamKey key in retiredNumbers.Keys)
            {
                number.Items.Add(key.RetiredNumber);
            }
        }
        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team whichTeam = Team.Jersey;
            RetiredTeamNumber retiredTeamNumber;
            int copiesOfThisRetiredNumber = retiredNumbers.Keys
                                .Count(n => n.RetiredNumber == 
                                    (int)number.SelectedItem && n.Team == whichTeam);
            if (copiesOfThisRetiredNumber==1)
            {
                retiredTeamNumber = retiredNumbers[new TeamKey((int)number.SelectedItem, whichTeam, 1)];
                nameLabel.Text = retiredTeamNumber.Player;
                yearLabel.Text = retiredTeamNumber.YearRetired.ToString();
            }
            else if (copiesOfThisRetiredNumber > 1)
            {
                //foreach (retiredNumbers.Keys
                //                .Where(n => n.RetiredNumber ==
                //                    (int)number.SelectedItem && n.Team == whichTeam),retiredTeamNumber)
                //List<var numRetired,var teamName,var copyNumber> listRetiredTeamNumber = 
                //            retiredNumbers.Keys.Where(n => n.RetiredNumber ==
                //                                                (int)number.SelectedItem && n.Team == whichTeam).ToList();
                //{

                //}
                //retiredNumbers.Keys.Where(n => n.RetiredNumber ==(int)number.SelectedItem && n.Team == whichTeam).ToList();
                retiredTeamNumber = retiredNumbers[new TeamKey((int)number.SelectedItem, whichTeam, 1)];
                nameLabel.Text = retiredTeamNumber.Player;
                yearLabel.Text = retiredTeamNumber.YearRetired.ToString();
            }
            //Choose retiredNumbers
            //int i=0;
            //do 
            //{
            //    i++;
            //} while (retiredNumbers.ContainsKey(new TeamKey((int)number.SelectedItem, whichTeam, i)));
            
            //if (i==1)
            //{
            //    RetiredTeamNumber retiredTeamNumber = retiredNumbers[new TeamKey((int)number.SelectedItem, whichTeam, i)];
            //    nameLabel.Text = retiredTeamNumber.Player;
            //    yearLabel.Text = retiredTeamNumber.YearRetired.ToString();
            //}
            //else if (i > 1)
            //{
            //    for (int j = 1; j < retiredNumbers.Keys.Count(n => n.RetiredNumber == (int)number.SelectedItem && n.Team == whichTeam);j++);
            //    {
            //    }
            //    RetiredTeamNumber retiredTeamNumber = retiredNumbers[new TeamKey((int)number.SelectedItem, whichTeam, i)];
            //}
        }
    }
}
