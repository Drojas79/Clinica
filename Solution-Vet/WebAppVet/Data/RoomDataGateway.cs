using ClientPatientManagement.Core.Interfaces;
using ClientPatientManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppVet.Data
{
    public class RoomDataGateway
    {
        public class roomfacade : IRepository<Room>
        {

            private static roomfacade room;
            public static roomfacade getRoomFacade() {
                if (room == null)
                {
                    room = new roomfacade();
                }
                return room;

            }


            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public Room GetById(int id)
            {
                throw new NotImplementedException();
            }

            public void Insert(Room entity)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<Room> List()
            {
                throw new NotImplementedException();
            }

            public void Update(Room entity)
            {
                throw new NotImplementedException();
            }
        }



        public static void add(string name, string location)
        {
            var strql = "insert";

        }





    }
}