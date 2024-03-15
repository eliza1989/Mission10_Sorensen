//Create the IBowling Repository with Bowlers and Teams

namespace Mission10API.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }
    }
}
