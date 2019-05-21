using ClientPatientManagement.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientPatientManagement.Core.Model
{
    public class Doctor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


    }
}
