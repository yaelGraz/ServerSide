using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
  
    public class Person
    {
        [Key]

        [Required] public string PersonId { get; set; }
        [Required] public string FirsteName { get; set; }
        [Required] public string LastName { get; set; }

        [Required] public DateTime BirthDate { get; set; }
        [Required] public virtual ICollection<Child> Children { get; set; }
        [Required] public string HMO { get; set; }
        [Required] public string Gender { get; set; }
    }
}
