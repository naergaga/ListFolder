using ListFolder.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DateTime AddTime { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return " Id: " + Id + " Name: " + Name + " Address: " + Address + " Description: " + Description;
        }
    }

    public class ProjectModel: BaseModel
    {
        private int id;
        private string name;
        private string address;
        private DateTime addTime;
        private string description;


        public int Id { get { return id; } set { RaisePropertyChanged("Id");id = value; } }
        public string Name { get { return name; } set { RaisePropertyChanged("Name"); name = value; } }
        public string Address { get { return address; } set { RaisePropertyChanged("Address"); address = value; } }
        public DateTime AddTime { get { return addTime; } set { RaisePropertyChanged("AddTime"); addTime = value; } }
        public string Description { get { return description; } set { RaisePropertyChanged("Description"); description = value; } }

        public override string ToString()
        {
            return " Id: " + Id + " Name: " + Name + " Address: " + Address + " Description: " + Description;
        }

        public Project ToProject()
        {
            return new Project
            {
                Id = Id,
                Name = Name,
                Address = Address,
                AddTime = AddTime,
                Description = Description
            };
        }
    }
}
