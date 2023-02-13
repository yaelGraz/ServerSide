using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository.Entities
{
    public class Child
    {
        [Required] public string ChildID { get; set; }
        [Required] public string ChildName { get; set; }

        [Required] public DateTime BirthDate { get; set; }
    }
}
