using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFolder.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return " Id: " + Id + " Name: " + Name + " Address: " + Address + " Description: " + Description;
        }
    }
}
