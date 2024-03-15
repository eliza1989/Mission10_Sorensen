//Bring in necessary packages
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Mission10API.Data
{
    //Create the bowlers "model" and set the key and build it to match incoming data
    public class Bowlers
    {
        [Key]
        public int? BowlerID { get; set; }
        public string? BowlerLastName { get; set; }

        public string? BowlerFirstName { get; set; }

        public string? BowlerMiddleInit { get; set; }

        public string? BowlerAddress { get; set; }

        public string? BowlerCity { get; set; }
        
       public string? BowlerState { get; set; }

        public string? BowlerZip { get; set; }

        public string? BowlerPhoneNumber { get; set; }

        public int? TeamID { get; set; }

        //Connect it to teams with the foreign key
        [ForeignKey("TeamID")]
        public Teams? TeamName { get; set; }
    }
}
