//Create the EF Bowling repository to make an instance of the database tables
//and setting that equal to _bowlingcontext


namespace Mission10API.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingContext _bowlingcontext;
        public EFBowlingRepository(BowlingContext temp) { 
            _bowlingcontext = temp;
        }
        public IEnumerable<Bowlers> Bowlers => _bowlingcontext.Bowlers;
        public IEnumerable<Teams> Teams => _bowlingcontext.Teams;
    }
}
