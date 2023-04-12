using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Inheritance
{
    internal class Team : Sponsor
    {
        private string _teamName;
        public Team(string name)
        {
            _teamName = name;
        }

        /// <summary>
        /// This method will Concate name of owner and team with Concat().
        /// </summary>
        public string printInfo()
        {
            string teamDetails = string.Concat(owner, _teamName);
            return teamDetails;
        }
    }
}
