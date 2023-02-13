using Server.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class PersonModel
    {
        [Required] public int PersonId { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public DateTime BirthDate { get; set; }
        [Required] public ICollection<Child> Children { get; set; }
        [Required] public string HMO { get; set; }
        [Required] public string Gender { get; set; }
    }
}
