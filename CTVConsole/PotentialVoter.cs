using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;


namespace CTVConsole
{
    class PotentialVoter
    {
        string name;
        int age;
        string occupation;
        string state;

        string CD;
        string SHD;
        string SSD;

        float probabilityOfVoting;
        bool intendingToVote;

        bool votedInPreviousElection;
        int numberOfVotesCast;
        string zipCode; 




        bool likelyVoter; 

        //database superkey - name, likelyVoter, zipCode - technically not a 'superkey' per se as obvs we can have people of the same name
        //but works same - we should then be able to join likelyVoter w/ the likelyVoter attribute in the likelyDemocratic/Republican voter tables

        public string setName(string name)
        {
            this.name = name;
            return this.name;
        }

        public string getName()
        {
            return this.name;
        }

        public int setAge(int age)
        {
            this.age = age;
            return this.age;
        }

        public int getAge()
        {
            return this.age;
        }

        public string setOccupation(string Occupation)
        {
            this.occupation = Occupation;
            return this.occupation;
        }

        public string getOccupation()
        {
            return this.occupation;
        }

        public bool setPreviousVoteStatus(bool previousVote)
        {
            if (previousVote == true)
            {
                this.votedInPreviousElection = true;
            }
            else
            {
                this.votedInPreviousElection = false;
            }
            return this.votedInPreviousElection;
        }

        public bool getPreviousVoteStatus()
        {
            return this.votedInPreviousElection;
        }

        public int setVoteNumber(int numberOfPreviousVotes)
        {
            this.numberOfVotesCast = numberOfPreviousVotes;
            return this.numberOfVotesCast;
  
        }

        public int getVoteNumber()
        {
            return this.numberOfVotesCast;
        }

        public float setProbabilityOfVoting(float voteProb)
        {
            this.probabilityOfVoting = voteProb;
            return this.probabilityOfVoting;
        }

        public float getProbabilityOfVoting()
        {
            return this.probabilityOfVoting;
        }

        public bool setVotingIntention(bool voteIntention)
        {
            if(voteIntention == true)
            {
                this.intendingToVote = true;
            }
            else
            {
                this.intendingToVote = false;
            }

            return this.intendingToVote;

        }

        public bool getVotingIntention()
        {
            return this.intendingToVote;
        }

        public bool setVoterStatus()
        {
            return false;
        }



        public bool getVoterStatus()
        {
            return this.likelyVoter;
        }

        



        

    }
}