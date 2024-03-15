//Briing in the necessary packages
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10API.Data;
using System.Runtime.CompilerServices;

//Create the Controllers
namespace Mission10API.Controllers
{
    //Create the route
    [Route("[controller]")]
    [ApiController]

    //Create the Bowlers Controller
    public class BowlersController : ControllerBase
    {
        //Connect to the _bowlingRepository
        private IBowlingRepository _bowlingRepository;
        //Create a temp instance of the repository
        public BowlersController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }



        //Create the HttpGet request for Bowlers
        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {

            //Create the variable that will grab the information from the database based on the query parameters given
            var bowlerData = from bowler in _bowlingRepository.Bowlers
                             join team in _bowlingRepository.Teams on bowler.TeamID equals team.TeamID
                             where team.TeamName == "Sharks" || team.TeamName == "Marlins" // Filter by team name
                             select new Bowlers
                             {
                                 //Select this information for the bowlers that meet the paramters above
                                 BowlerID = bowler.BowlerID,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamName = team // Assign the Team directly
                             };

            //Return all the data that was collected in a list
            return bowlerData.ToList();
        }
        
           

    }
}
