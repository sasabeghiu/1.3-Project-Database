using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class RoomService
    {
        RoomDao roomdb;

        public RoomService()
        {
            roomdb = new RoomDao();
        }
        //returns a lsit with rooms
        public List<Room> GetRooms()
        {
            List<Room> rooms = roomdb.GetAllRooms();
            return rooms;
        }
    }
}
