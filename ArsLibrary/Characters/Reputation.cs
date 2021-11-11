namespace ArsLibrary.Characters
{
    public class Reputation
    {
        public string ReputationName { get; set; }
        public int ReputationLevel { get; set; }

        public Reputation(string reputationName, int level)
        {
            ReputationName = reputationName;
            ReputationLevel = level;
        }
    }
}