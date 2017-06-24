using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTVConsole
{
    class LikelyDemocraticVoter : PotentialVoter
    {

        string name;
        bool likelyVoter;
        int zipcode;

        bool supportsUHC;
        bool supports15MinWage;
        bool supports12MinWage;
        bool supportedIraqWar;
        bool votedForObama;
        bool sandersSupporter;
        bool hillarySupporter;

        bool ownsGuns;



        bool isDemocraticVoter;

        public LikelyDemocraticVoter(PotentialVoter potentialVoter)
        {
            this.name = potentialVoter.getName();
            this.likelyVoter = potentialVoter.likelyVoter;
        }

        public bool setDemocraticVoter()
        {
            this.isDemocraticVoter = true;
            return this.isDemocraticVoter;
        }
    
        public bool getDemocraticVoter()
        {
            return this.isDemocraticVoter;
        }
        


    }
}
