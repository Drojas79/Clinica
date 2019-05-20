using System;
using ClientPatientManagement.Core.Interface;

namespace ClientPatientManagement.Core.Models
{
    public partial class Room:IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }

    }
}