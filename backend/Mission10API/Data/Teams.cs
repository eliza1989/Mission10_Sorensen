//USe Annotation
using System.ComponentModel.DataAnnotations;

//Create the Teams "model"
namespace Mission10API.Data
{
    //Build the expexted information and set the key for teams
    public class Teams
    {
        [Key]
        public int TeamID { get; set; }

        public string? TeamName { get; set; }

        public int CaptainID { get; set; }
    }
}
