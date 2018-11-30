﻿namespace FitnessApp.ViewModels
{
    class ChallengeItem
    {
        //private string challengeImage;
        private string challengeName;
        private string challengeDescription;
        private string challengeDueDate;
        private string challengeTarget;
        private string challengeReward;

        public ChallengeItem(string _challengeName, string _challengeDescription, string _challengeDueDate, string _challengeTarget, string _challengeReward)
        {
            challengeName = _challengeName;
            challengeDescription = _challengeDescription;
            challengeDueDate = _challengeDueDate;
            challengeTarget = _challengeTarget;
            challengeReward = _challengeReward;
        }

        public string ChallengeName
        {
            get { return challengeName; }
            set { }
        }

        public string ChallengeDescription
        {
            get { return challengeDescription; }
            set { }
        }

        public string ChallengeDueDate
        {
            get { return challengeDueDate; }
            set { }
        }

        public string ChallengeTarget
        {
            get { return challengeTarget; }
            set { }
        }

        public string ChallengeReward
        {
            get { return challengeReward; }
            set { }
        }
    }
}
